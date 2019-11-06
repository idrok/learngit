using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

//SkipWhile 忽略在特定条件下的流，从流开始位置计算
public class UniRxSkipWhileExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .SkipWhile((_, times) => times < 300)
            .Subscribe(_ => print("mouse click"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
