using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// last 一次流操作中最后一个满足条件的筛选
// 当战斗中的逻辑不符合流操作，可以手动来Create<T>创建一个系列流
// 在OnNext方法里面去存放系列数据
public class UniRxLastExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var observer = Observable.Create<int>(_observer =>
        {
            _observer.OnNext(3);
            _observer.OnNext(2);
            _observer.OnNext(1);
            _observer.OnCompleted();
            return Disposable.Create((() => print("dispose")));
        });

        observer.Last(number => number > 2)
            .Subscribe(_ => { print(_); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
