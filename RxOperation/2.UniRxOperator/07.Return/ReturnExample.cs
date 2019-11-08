using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

//return 相当于一个set接口
public class ReturnExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.Return("hello world")
            .Subscribe(_ => print(_));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
