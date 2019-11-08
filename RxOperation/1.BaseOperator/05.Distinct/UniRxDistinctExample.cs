using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// Distinct 去除一次流操作中重复的结果
public class UniRxDistinctExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var leftMouseClickStream = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0))
            .Select(_ => "LeftMouseClicked");
        var rightMouseClickStream = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(1))
            .Select(_ => "RightMouseClicked");

        Observable.Merge(leftMouseClickStream, rightMouseClickStream)
            .Distinct()
            .Subscribe(print);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
