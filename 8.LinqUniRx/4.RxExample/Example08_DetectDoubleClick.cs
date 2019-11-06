using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// Buffer关键字可以将一个时间段里面的数据统计到一起
// Throttle关键字可以将事件流挂起一段时间，每次这个固定时间到达ToNext
// 为什么挂起了还在执行，因为每次一个关键字都是创建了一个新的Observable
public class Example08_DetectDoubleClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var clickStream = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0));
        var clickThrottle = clickStream.Throttle(TimeSpan.FromMilliseconds(500));
        clickStream.Buffer(clickThrottle)
            .Where(_ => _.Count >= 2)
            .Subscribe(_ => print("double click:" + _.Count));

        //Observable.EveryApplicationPause().Subscribe(_ => print("i am pause"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
