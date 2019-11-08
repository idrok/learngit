using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// 帧间隔tag
public class FrameIntervalExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            //.Timestamp()
            //.TimeInterval()
            .FrameInterval()
            .Subscribe(_ => print("f:" + _.Interval + "  t:" + _.Value));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
