using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// 单次事件请求超时，没超时可以一直执行，超时结束
public class ThrottleExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0))
            .Throttle(TimeSpan.FromSeconds(1))
            .Subscribe(_ => print("n throttle times later"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
