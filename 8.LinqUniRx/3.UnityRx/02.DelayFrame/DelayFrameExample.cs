using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// 延迟帧数
public class DelayFrameExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(Time.frameCount);

        Observable.ReturnUnit()
            .Do(_ => print(Time.frameCount))
            .DelayFrame(10)
            .Do(_ => print(Time.frameCount))
            .Subscribe(_ => print(Time.frameCount));
    }
}
