using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UniRx;
using UnityEngine;

public class _03_ObservableConcat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start_03_ObservableConcat()//observable本身合成
    {
        var valueStream = Observable.Interval(TimeSpan.FromSeconds(3));
        var clickStream = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0));
//        Observable.Amb(valueStream, clickStream).Subscribe(_ => print(_));
//        Observable.Zip(valueStream, clickStream).Subscribe(x => x.ToList().ForEach(y => print(y)));
//        Observable.ZipLatest(valueStream, clickStream).Subscribe(x => x.ToList().ForEach(y => print(y)));
//        Observable.CombineLatest(valueStream, clickStream).Subscribe(x => x.ToList().ForEach(y => print(y)));
        /*Observable.WithLatestFrom(valueStream, clickStream, (v, c) =>
        {
            if (v < 3)
            {
                return v;
            }
            else
            {
                return c;
            }
            return v;
        }).Subscribe(x => print(x));*/

//        Observable.Merge(valueStream, clickStream).Subscribe(x => print(x));
//        Observable.Concat(Observable.Return<long>(100), valueStream).Subscribe(x => print(x));
//        Observable.Return(66).SelectMany(Observable.Return(77)).Subscribe(y => print(y));
//        valueStream.Catch(e => { });??
    }

    void Start_04_TransformObservable()//转换Observable
    {
        //        var reactiveProperty = Observable.Return(100).ToReactiveProperty();
        //        print(reactiveProperty.Value);
//        var readOnlyReactiveProperty = Observable.Return(666).ToReadOnlyReactiveProperty();
//        print(readOnlyReactiveProperty.Value);

//        StartCoroutine(TestA());
    }

    IEnumerator TestA()
    {
        var observable = Observable.Return(110);
        yield return observable.ToYieldInstruction();
        observable.Subscribe(x => print(x));
    }

    void Start_ObserverBranch()//可观察的分支
    {
        /*var clickStream = Observable.EveryUpdate();
        var publishStream = clickStream.Publish(100);
        publishStream.Subscribe(_ => print("ok"));
        publishStream.Where(_ => Input.GetMouseButtonDown(0)).Subscribe(_ => print("super me"));*/

        Observable.EveryUpdate()//.Where(_ => Input.GetMouseButtonDown(0))
            .Take(100)
            .Replay(200)
            .Subscribe(x => print(x));
    }

    void Start_CombineMessage()//消息之间的组合
    {
        Observable.EveryUpdate().Buffer(TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(10))
            .Subscribe(x => x.ToList().ForEach(y => print(y)));
    }

    void Start_Transform()//转换邮件
    {
        //Observable.Return(100).AsUnitObservable().Subscribe(x => print(x));
        Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0))
            .Timestamp().Subscribe(x => print( x.Timestamp.LocalDateTime.ToString()));
    }

    void Start_TimeHandle()
    {
//        Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0))
//            .Timeout(TimeSpan.FromSeconds(1))
//            .Subscribe(_ => print("ok"), exception => print("err"));
//        Observable.NextFrame().Subscribe(_ => print("fx show!"));
    }

    void Start_AsyncOperator()
    {
//        Observable.ToAsync<int>(() =>
//        {
//            print("ok");
//            return 1;
//        });

//        int i = 0;
//        Observable.Start<int>(() =>
//        {
//            ++i;
//            return 1;
//        }, TimeSpan.FromSeconds(1)).Subscribe(_ => print(i));

//        Observable.Return(100).ObserveOn(Scheduler.ThreadPool)
//            .Subscribe(_ => print("ok"));

//        Observable.ContinueWith()
    }

    void Start_ExceptionHandle()
    {
//        Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0))
//            .Timeout(TimeSpan.FromSeconds(1))
//            .Retry(1)
//            .Catch<long, Exception>(l =>
//            {
//                print(l.Message);
//                return Observable.Return<long>(110);
//            })
//            .CatchIgnore()
//            .Subscribe(_ => print("ok ?"));
    }

    void Start_FinishObservableLater()
    {
//        Observable.RepeatUntilDisable(gameObject)
//            .Subscribe(_ => print("ok"));

//        Observable.Return(666).Finally(() => { print("gameover"); }).Subscribe(x => print(x));
//        Observable.Return(666).RepeatUntilDestroy(gameObject).Subscribe(x => print(x));
//        Observable.Timer(TimeSpan.FromSeconds(1)).Subscribe(_ => Destroy(gameObject));
    }

    void Start_IfNot()
    {
        //Observable.Return(666).StartWith(998).Subscribe(x => print(x));
//        var clickStream = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0))
//            .Do(_ =>print("do")).DoOnSubscribe(()=>print("subscribe")).DoOnCompleted(()=>print("com")).Synchronize(this);
//        var rangStream = Observable.Range(1, 10);
//        clickStream.Wait(TimeSpan.FromSeconds(1));
//        clickStream.Subscribe(_ => print("Ok"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
