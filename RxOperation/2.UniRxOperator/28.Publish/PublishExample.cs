using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// Publish 将普通的Observable转换成可以Connect的Observable
// Publish会基于OnNext来拆分流数据，再调用Connect之后开始执行
public class PublishExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var unShared = Observable.Range(1, 3);
        unShared.Subscribe(_ => print("un1 :" + _));
        unShared.Subscribe(_ => print("un2 :" + _));

        var shared = unShared.Publish();
        shared.Subscribe(_ => print("1 :" + _));
        shared.Subscribe(_ => print("2 :" + _));

        Observable.Timer(TimeSpan.FromSeconds(3))
            .Subscribe(_ => shared.Connect());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
