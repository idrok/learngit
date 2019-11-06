using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class UniRxToListExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var subject = new Subject<float>();

        subject.ToList()
            .Subscribe(timeList =>
            {
                foreach (var time in timeList)
                {
                    Debug.Log(time);
                }
            });

        Observable.Timer(TimeSpan.FromSeconds(1.0f))
            .Repeat()
            .Take(5)
            .Subscribe(_ => subject.OnNext(Time.time), () => subject.OnCompleted());
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
