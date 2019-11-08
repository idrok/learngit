using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// 采样帧数，每多少帧执行一次
public class SampleFrameExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .SampleFrame(5)
            .Subscribe(_ => { print(Time.frameCount); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
