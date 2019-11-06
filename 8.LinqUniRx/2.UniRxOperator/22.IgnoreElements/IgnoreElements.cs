using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// skip 中间的数据
public class IgnoreElements : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var subject = new Subject<int>();
        var ignoreElements = subject.IgnoreElements();

        //subject.Subscribe(_ => print(_));
        ignoreElements.Subscribe(_ => print(_));

        subject.OnNext(1);
        subject.OnNext(2);
        subject.OnNext(3);
        subject.OnCompleted();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
