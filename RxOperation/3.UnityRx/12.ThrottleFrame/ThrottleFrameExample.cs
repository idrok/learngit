using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// Throttle插入阈值间隔帧
public class ThrottleFrameExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Select(_ => ++i)
            .Do(_ => print("c:" + _))
            .ThrottleFrame(100)
            .Do(_ => print("end 100 f"))
            .Subscribe(_ => print("p:" + _));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
