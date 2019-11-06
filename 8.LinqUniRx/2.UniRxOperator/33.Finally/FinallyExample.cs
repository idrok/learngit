using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// 当对象完成以后、异常都会执行的代码
public class FinallyExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var subject = new Subject<int>();
        var result = subject.Finally(() => Debug.Log("Finally action run"));

        result.Subscribe(number => Debug.LogFormat("OnNext({0});", number), () => Debug.Log("OnCompleted"));

        subject.OnNext(1);
        subject.OnNext(2);
        subject.OnNext(3);
        //subject.OnError(new Exception());
        subject.OnCompleted();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
