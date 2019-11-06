using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UniRx;
using UnityEngine;

// 线程数据和Observable交互
public class ObserveOnMainThreadExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(Time.time);

        Observable.Start(() =>
        {
            Thread.Sleep(TimeSpan.FromSeconds(10));
            return "hello thread";
        }).ObserveOnMainThread()
            .Subscribe(_ => print("r:" + _ + "  t:" + Time.time));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
