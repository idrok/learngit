using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

//unirx interval 间隔时间循环
public class UniRxInterval : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.Interval(TimeSpan.FromSeconds(1))
            .Subscribe(_ => print(_));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
