using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// 异步ForEach，再Subscribe执行之前开始执行
public class ForEachAsyncExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.Range(0, 3)
            .ForEachAsync(_ => print("f:" + _))
            .Select(_ => "1000")
            .Subscribe(_ => print("s:" + _));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
