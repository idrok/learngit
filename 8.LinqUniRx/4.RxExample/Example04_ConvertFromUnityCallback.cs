using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class Example04_ConvertFromUnityCallback : MonoBehaviour
{
    private class LogCallback
    {
        public string Condition;
        public string StackTrace;
        public UnityEngine.LogType LogType;
    }

    static class LogHelper
    {
        public static IObservable<LogCallback> LogCallbackAsObservable()
        {
            return Observable.FromEvent<Application.LogCallback, LogCallback>(
                h => (condition, stackTrace, type) => h(new LogCallback { Condition = condition, StackTrace = stackTrace, LogType = type }),
                h => Application.logMessageReceived += h, h => Application.logMessageReceived -= h);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        LogHelper.LogCallbackAsObservable()
            .Where(x => x.LogType == LogType.Warning)
            .Subscribe(x => print(x));

        Debug.LogWarning("911");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
