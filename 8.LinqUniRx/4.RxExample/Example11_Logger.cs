using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Diagnostics;
using Logger = UniRx.Diagnostics.Logger;

public class Example11_Logger : MonoBehaviour
{
    static readonly Logger _logger = new Logger("ExampleLog");
    
    void Start()
    {
        ObservableLogger.Listener.LogToUnityDebug();

        ObservableLogger.Listener
            .Where(_ => _.LogType == LogType.Exception)
            .Subscribe(_ => print(_.Exception.Message));

        _logger.Debug("debug message");
        _logger.Log("log");
        _logger.Exception(new Exception("exception"));
    }
}
