using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// exception throw
public class ThrowExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.Throw<string>(new Exception("error"))
            .Subscribe(_ => Debug.Log("不会输出"), e => Debug.LogFormat("发现异常:{0}", e.Message));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
