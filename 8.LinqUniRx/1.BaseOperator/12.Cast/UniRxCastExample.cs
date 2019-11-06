using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

//Cast 转换一个流数据的类型
public class UniRxCastExample : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        var subject = new Subject<object>();

        subject.Cast<object, string>()
            .Subscribe(value => Debug.Log(value), e =>
            {
                Debug.Log("has exception");
                Debug.LogException(e);
            });

        subject.OnNext("123123");
        subject.OnNext("123123");
        subject.OnNext(123);
        subject.OnCompleted();
    }
    
    public void Cast()
    {
        //Observable.Range(1, 3).Cast<int, object>().ToArrayWait().IsCollection(1, 2, 3);
    }
    
    public void OfType()
    {
        var subject = new Subject<object>();

        var list = new List<int>();
        subject.OfType(default(int)).Subscribe(x => list.Add(x));

        subject.OnNext(1);
        subject.OnNext(2);
        subject.OnNext("hogehoge");
        subject.OnNext(3);

        //list.IsCollection(1, 2, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
