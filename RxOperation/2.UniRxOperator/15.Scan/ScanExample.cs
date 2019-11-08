using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// scan 一般用于计数，串联流一起处理
public class ScanExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Scan(0, (i, l) => ++i)
            .Subscribe(_ => print(_));

        int count = 0;
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Select(_ => count = count + 1)
            .Subscribe(_ => print(":"+_));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
