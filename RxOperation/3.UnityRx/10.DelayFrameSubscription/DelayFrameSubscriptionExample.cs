using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// 延迟帧数订阅
public class DelayFrameSubscriptionExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Time.frameCount);

        Observable.ReturnUnit()
            .DelayFrameSubscription(10)
            .Subscribe(_ => Debug.Log(Time.frameCount));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
