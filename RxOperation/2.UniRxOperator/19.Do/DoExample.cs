using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// 数据流中间的执行方法
// 类似的方法Select选择一个结果和Subscribe结束流传播
public class DoExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.ReturnUnit()
            .Delay(TimeSpan.FromSeconds(1))
            .Do(_ => print("1 seconds"))
            .Delay(TimeSpan.FromSeconds(1))
            .Do(_ => print("2 seconds"))
            .Delay(TimeSpan.FromSeconds(1))
            .Do(_ => print("3 seconds"))
            .Subscribe(_ => print("over"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
