using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// 重复一个事件流直到destroy
public class RepeatUntilDestroyExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.Timer(TimeSpan.FromSeconds(1))
            .RepeatUntilDestroy(this)
            .Subscribe(_ => print("ticked"));

        Observable.Timer(TimeSpan.FromSeconds(5))
            .Do(_ => Destroy(this.gameObject))
            .Subscribe();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
