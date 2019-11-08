using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// Timer定时器功能
public class RxTimerExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.Timer(TimeSpan.FromSeconds(1))
            .Subscribe(_ => print("1 seconds later"));
    }
}
