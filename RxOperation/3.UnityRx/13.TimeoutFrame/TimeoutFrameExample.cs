using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// 超时帧
public class TimeoutFrameExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Do(_ => Debug.LogFormat("clicked frame:{0}", Time.frameCount))
            .TimeoutFrame(120)
            .Subscribe(_ => Debug.Log("mouse clicked"), e =>
            {
                Debug.LogFormat("excpetion frame count:{0}", Time.frameCount);
            });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
