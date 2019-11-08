using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// 在给定的多个obserable中只使用最先发射的observable
public class AmbExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.Amb(
            Observable.Timer(TimeSpan.FromSeconds(0.5f)).Select(_ => "0.5 sec"),
            Observable.Timer(TimeSpan.FromSeconds(3.0f)).Select(_ => "3 sec"),
            Observable.Timer(TimeSpan.FromSeconds(1.0f)).Select(_ => "1 sec"),
            Observable.Timer(TimeSpan.FromSeconds(7.0f)).Select(_ => "7 sec"),
            Observable.Timer(TimeSpan.FromSeconds(9.0f)).Select(_ => "9 sec")
        ).Subscribe(observableName =>
        {
            Debug.Log(observableName);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
