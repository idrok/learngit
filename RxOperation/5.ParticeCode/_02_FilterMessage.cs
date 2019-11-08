using System;
using UniRx;
using UnityEngine;

public class _02_FilterMessage : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
//        Observable.Range(1, 100).Where(x => x == 66).Subscribe(y => print(y));

//        var stream100 = Observable.Return(100);
//        var streamSame100 = Observable.Return(100);
//        var stream66 = Observable.Return(66);
//        Observable.Concat(stream66, stream100, streamSame100).Distinct().Subscribe(x => print(x));
//        Observable.Merge(stream66, stream100, streamSame100).DistinctUntilChanged().Subscribe(x => print(x));

//        var streamInterval = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0));
//        var stteamThrottle = streamInterval.Throttle(TimeSpan.FromSeconds(1));
//        streamInterval.Buffer(stteamThrottle).Subscribe(x =>  print("throttle:" + x));
//        var streamInterval = Observable.Interval(TimeSpan.FromMilliseconds(100)).Where(_=>Input.GetMouseButtonDown(0));
//        var stteamThrottle = streamInterval.Throttle(TimeSpan.FromSeconds(1));
//        stteamThrottle.Subscribe(x =>  print("throttle:" + x));

//        Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0))
//            .ThrottleFirst(TimeSpan.FromMilliseconds(1000))
//            .Subscribe(_ => print("ok"));

//        Observable.Range(-100, 1000).FirstOrDefault(x =>
//        {
//            if (x == 666) return true; 
//            return false;
//        }).Subscribe(x => print(x));

//        Observable.EveryUpdate().Single().Subscribe(x => print(x));
//        Observable.Range(1, 10).Last().Subscribe(x => print(x));

//        Observable.Interval(TimeSpan.FromMilliseconds(100))
//            .Take(TimeSpan.FromMilliseconds(500))
//            .Subscribe(x => print(x));

//        Observable.EveryUpdate().TakeWhile(x => x == 0)
//            .Subscribe(x => print("f:" + x));

//        var streamClick = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0));
//        Observable.EveryUpdate().Select(x =>
//            {
//                if (x % 60 == 0)
//                {
//                    print("60");
//                    return true;
//                }
//                return false;
//            }).TakeUntil(streamClick)
//            .Subscribe(_ => print("xixixi"));
//        Observable.EveryUpdate().Skip(100).Subscribe(x => print(x));
//        Observable.EveryUpdate().SkipWhile(x => x == 0).Subscribe(x => print(x));
//        Observable.EveryUpdate().SkipUntil(streamClick).Subscribe(x => print(x));
//        Observable.EveryUpdate().IgnoreElements()
//            .Subscribe(x => print(x), _ => print("ex"), () => print("com"));

        /*var subject = new Subject<int>();
        subject.OfType<int, int>().Subscribe(x => print(x));
        subject.OnNext(10);
        subject.OnNext(100);
        subject.OnNext(1000);
        subject.OnCompleted();*/

    }

    // Update is called once per frame
    private void Update()
    {
    }
}