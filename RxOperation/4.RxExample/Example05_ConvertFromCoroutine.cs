using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UniRx;
using UnityEngine;

public class Example05_ConvertFromCoroutine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FunctionConvertCoroutine.GetWWW("https://www.sina.com.cn/")
            .Subscribe(_ => print(_));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class FunctionConvertCoroutine
{
    public static IObservable<string> GetWWW(string url)
    {
        return Observable.FromCoroutine<string>((o, c) => GetWWWCore(url, o, c));
    }

    static IEnumerator GetWWWCore(string url, IObserver<string> observer, CancellationToken cancellationToken)
    {
        var www = new UnityEngine.WWW(url);
        while (!www.isDone && !cancellationToken.IsCancellationRequested)
        {
            yield return null;
        }

        if (www.error != null)
        {
            observer.OnError(new Exception(www.error));
        }
        else
        {
            observer.OnNext(www.text);
            observer.OnCompleted();
        }
    }
}
