using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// Replay 同步同一个Observable数据
public class ReplayExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var replayObservable = Observable.Interval(TimeSpan.FromSeconds(1))
            .Do(_ => print("observable:" + _))
            .Replay();

        replayObservable.Subscribe(_ => print("------#1:" + _));
        replayObservable.Connect();

        Observable.Timer(TimeSpan.FromSeconds(3.0f))
            .Subscribe(_ =>
            {
                replayObservable.Subscribe(l => Debug.LogFormat("------#2:{0}", l));
            });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
