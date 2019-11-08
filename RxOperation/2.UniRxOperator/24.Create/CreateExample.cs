using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// Create创建一个流
public class CreateExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.Create<int>(o =>
        {
            o.OnNext(1);
            o.OnNext(2);
            Observable.Timer(TimeSpan.FromSeconds(1))
                .Subscribe(_ => o.OnCompleted());

            return Disposable.Create(() => print("disposable"));
        }).Subscribe(_ => print(_));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
