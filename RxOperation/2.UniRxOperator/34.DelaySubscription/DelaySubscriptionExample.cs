using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// 延迟订阅数据流
public class DelaySubscriptionExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Time.time);

        Observable.ReturnUnit()
            .DelaySubscription(TimeSpan.FromSeconds(1.0f))
            .Subscribe(_ => Debug.Log(Time.time));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
