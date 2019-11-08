using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

//TakeWhile 当流满足一定条件开始截取前面的数据
public class UniRxTakeWhileExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButton(0))
            .TakeWhile((_, number) => !Input.GetMouseButtonUp(0) && number < 100)
            .Subscribe(_ => print("mouse button clicking"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
