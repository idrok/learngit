using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

//Range 生成一个有start开始长度为count的连续自然数
public class UniRxRangeExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.Range(5, 10).Select(x => x * x)
            .Subscribe(_ => { print(_); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
