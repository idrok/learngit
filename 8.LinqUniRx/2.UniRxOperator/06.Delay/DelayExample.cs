using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// delay 延迟多久
public class DelayExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.Timer(TimeSpan.FromSeconds(1))
            .Select(_ =>
            {
                print("1 seconds");
                return _;
            })
            .Delay(TimeSpan.FromSeconds(1))
            .Select(_ =>
            {
                print("2 seconds");
                return _;
            })
            .Delay(TimeSpan.FromSeconds(1))
            .Subscribe(_ => print("3 seconds"));

        Observable.ReturnUnit()
            .Delay(TimeSpan.FromSeconds(1.0f))
            .Subscribe();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
