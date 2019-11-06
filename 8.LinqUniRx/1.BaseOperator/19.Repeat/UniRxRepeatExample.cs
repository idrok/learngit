using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

//Repeat 对之前的流进行重复操作
public class UniRxRepeatExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.Timer(TimeSpan.FromSeconds(1))
            .Repeat()
            .Subscribe(_ => print("after 1 seconds"))
            .AddTo(this);

        this.UpdateAsObservable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
