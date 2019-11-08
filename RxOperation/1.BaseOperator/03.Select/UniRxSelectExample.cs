using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

//select 一次流操作的结果指定
public class UniRxSelectExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
//        Observable.EveryUpdate()
//            .Select(_ => "select string")
//            .Subscribe(select =>
//            {
//                print(select);
//            }).AddTo(this);

        var query = from frameUpdate in Observable.EveryUpdate() select "this is select";
        query.Subscribe(print);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
