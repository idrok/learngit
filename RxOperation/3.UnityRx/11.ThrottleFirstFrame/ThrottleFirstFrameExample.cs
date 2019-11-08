using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// 每多少帧之后的一个事件将会有效，其他忽略
public class ThrottleFirstFrameExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .ThrottleFirstFrame(100)
            .Subscribe(_ => print("clicked: " + _));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
