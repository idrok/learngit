using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// first 一次流操作只取值第一个流发出的数据
public class UniRxFirstExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .First(_ => Input.GetMouseButtonDown(0))
            .Subscribe(_ => { print("mouse down"); })
            .AddTo(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
