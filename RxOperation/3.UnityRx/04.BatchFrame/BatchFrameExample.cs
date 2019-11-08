using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// 帧数批处理筛选
// 在一定的帧数里面处理流
public class BatchFrameExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .BatchFrame(100, FrameCountType.EndOfFrame)
            .Subscribe(_ => print(_.Count));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
