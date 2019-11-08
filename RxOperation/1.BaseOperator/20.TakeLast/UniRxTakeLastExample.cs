using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// TakeLast 获取最后的n个元素
public class UniRxTakeLastExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //        Observable.Range(5, 5)
        //            .TakeLast(3)
        //            .Subscribe(_ => print(_));

        var subject = new Subject<float>();

        subject
            .TakeLast(TimeSpan.FromSeconds(2.0))
            .Subscribe(clickedTime => Debug.Log(clickedTime));


        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Subscribe(_ => subject.OnNext(Time.time));

        Observable.Timer(TimeSpan.FromSeconds(5.0f))
            .Subscribe(_ => subject.OnCompleted());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
