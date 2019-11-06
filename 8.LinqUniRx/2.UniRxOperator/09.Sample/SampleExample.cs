using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

//Sample多久对操作的数据进行采用
public class SampleExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int clickCount = 0;
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Select(_ => clickCount++)
            .Sample(TimeSpan.FromSeconds(3))
            .Subscribe(_ => print(clickCount));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
