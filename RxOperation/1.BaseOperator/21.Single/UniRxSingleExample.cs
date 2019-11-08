using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// Single 判定发布的单值是否满足条件
public class UniRxSingleExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var subject = new Subject<int>();
        subject.Single(_ => _ == 10)
            .Subscribe(_ => print(_));

        subject.OnNext(11);
        subject.OnNext(22);
        subject.OnNext(10);
        subject.OnNext(33);
        subject.OnCompleted();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
