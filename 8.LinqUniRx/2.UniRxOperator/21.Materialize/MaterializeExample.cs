using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// Materialize是将流节点执行过程打印出来，方便查看
// Dematerialize将流节点串联起来
public class MaterializeExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.Range(1, 3)
            .Materialize()
            //.Dematerialize()
            .Subscribe(x =>
            {
                print(x);
            });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
