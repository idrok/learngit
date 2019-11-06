using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// UniRx和外面接口通信方式
public class FromEventExample : MonoBehaviour
{
    private event Action mOnMouseDownEvent;
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Subscribe(_ => mOnMouseDownEvent.Invoke());

        Observable.FromEvent(_ => mOnMouseDownEvent += _,
                _r => mOnMouseDownEvent -= _r)
            .Subscribe(_ => print("mouse clicked"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
