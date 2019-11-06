using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// Skip 忽略一次流处理之前的内容
public class UniRxSkipExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Skip(TimeSpan.FromSeconds(5))
            .Subscribe(_ => print("mouse click"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
