using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// 直到 某种 程度我才终止已经开始的take
public class UniRxTakeUntilExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate().TakeUntil(Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0)))
            .Subscribe(_ => print("OK"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
