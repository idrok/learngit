using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// DistinctUntilChange 数据合并直到数据有变化
public class DistinctUntilChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var state = "runstate";

        Observable.EveryUpdate()
            .DistinctUntilChanged(_ => state)
            .Subscribe(_ => print("no state change :" + state ));

        Observable.ReturnUnit()
            .Delay(TimeSpan.FromSeconds(3))
            .Do(_ => state = "jumpstate")
            .Delay(TimeSpan.FromSeconds(3))
            .Do(_ => state = "idlestate")
            .Subscribe();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
