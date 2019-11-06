using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UniRx;
using UnityEngine;

// 将数据缓存到buffer再处理
// 单次缓冲buffer数量然后再执行处理
public class BufferExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
//        Observable.Interval(TimeSpan.FromSeconds(1))
//            .Buffer(TimeSpan.FromSeconds(4))
//            .Subscribe(_ => _.ToList().ForEach(__ => print(__)));

        Observable.EveryUpdate()
            .Buffer(100)
            .Subscribe(_ => _.ToList().ForEach(__ => print(__)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
