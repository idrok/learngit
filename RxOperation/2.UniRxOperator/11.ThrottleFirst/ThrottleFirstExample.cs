using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// 在一个事件流中阻隔第一次
public class ThrottleFirstExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0))
            .ThrottleFirst(TimeSpan.FromSeconds(3))
            .Subscribe(_ => print("clicked!"));
    }
}
