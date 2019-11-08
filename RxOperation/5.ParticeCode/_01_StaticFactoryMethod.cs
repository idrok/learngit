using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.Events;

public class _01_StaticFactoryMethod : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
//        Observable.Return("hello").Subscribe(x => print(x));
//        Observable.Repeat("hello", 10000, Scheduler.ThreadPool).Subscribe(x => print(x));
//        Observable.Range(1, 10).Subscribe(x => print(x));
//        Observable.Defer(() => Observable.Return("hello")).Subscribe(x => print(x));
//        Observable.Timer(TimeSpan.FromSeconds(3), TimeSpan.FromSeconds(1)).Subscribe(_ => print("ok"));//later,interval
//        Observable.TimerFrame(100, 10).Subscribe(_ => print("ok"));
        
        /*Observable.Create<GameObject>(x =>
        {
            x.OnNext(new GameObject("10"));
            x.OnNext(new GameObject("100"));
            x.OnNext(new GameObject("1000"));
            x.OnCompleted();

            return Disposable.Empty;
        }).Subscribe(x => print(x.name + ":" + x.GetHashCode()));*/
//        Observable.Throw<string>(new Exception("nil exception")).Subscribe(_ => print(_), x => print(x.Message), () => print("complete"));
//        Observable.Empty<string>("Empty").Subscribe(x => print(x),()=>print("ok"));
//        Observable.Never<string>("Never").Subscribe(_ => print("Never"));
        /*Action<int> fooFoo = null;
        CompositeDisposable disposable = new CompositeDisposable(1);
        Observable.FromEvent<int>(h => fooFoo += h, h => fooFoo -= h).Subscribe(x => print(x)).AddTo(disposable);
        fooFoo(10);
        fooFoo(100);
        fooFoo(1000);
        disposable.Dispose();*/
//        Observable.EveryUpdate().Subscribe();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
