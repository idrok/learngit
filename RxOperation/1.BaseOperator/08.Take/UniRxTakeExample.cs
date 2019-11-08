using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// take一次流操作中，取前一个序列的数据
public class UniRxTakeExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .Take(100)
            .Subscribe(_ =>
            {
                _ += 1;
                print("这是第" + _ + "帧/100帧");
            });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
