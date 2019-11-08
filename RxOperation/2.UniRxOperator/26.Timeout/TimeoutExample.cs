using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.Networking;

// 数据流操作超时
public class TimeoutExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Timeout(TimeSpan.FromSeconds(3))
            .Subscribe(_ => print("clicked"));

#pragma warning disable 618
        ObservableWWW.Get("http://google.com")
#pragma warning restore 618
            .Timeout(TimeSpan.FromSeconds(1))
            .Subscribe(print, _ => print("err" + _));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
