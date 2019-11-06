using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// Switch 当有多个执行结果的时候，需要进行切换
public class SwitchExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //        var jumpState = Observable.Return("jump state");
        //
        //        Observable.EveryUpdate()
        //            .Where(_ => Input.GetKeyDown(KeyCode.Space))
        //            .Select(_ => jumpState)
        //            .Switch()
        //            .Subscribe(print);

        //        var wObservable = Observable.EveryUpdate().Where(_ => Input.GetKeyDown(KeyCode.W));
        //        var aObservable = Observable.EveryUpdate().Where(_ => Input.GetKeyDown(KeyCode.A));
        //        var sObservable = Observable.EveryUpdate().Where(_ => Input.GetKeyDown(KeyCode.S));
        //        var dObservable = Observable.EveryUpdate().Where(_ => Input.GetKeyDown(KeyCode.D));
        //
        //        wObservable.Select(_ => aObservable)
        //            .Switch()
        //            .Select(_ => sObservable)
        //            .Switch()
        //            .Select(_ => dObservable)
        //            .Switch()
        //            .Subscribe(_ => print("ok"));

        // Aキーを押すと、その時のフレーム数が一定間隔で表示され続ける
        // もう一度押すと、その時のフレーム数と前回のフレーム数が一定間隔で表示され続ける
        //        Observable.EveryUpdate()
        //            .Where(_ => Input.GetKeyDown(KeyCode.A))
        //            .Select(_ => Time.frameCount)
        //            .SelectMany(x => Observable.IntervalFrame(60).Do(_ => Debug.Log(x)))
        //            .Subscribe()
        //            .AddTo(this);

        // Aキーを押すと、その時のフレーム数が一定間隔で表示され続ける
        // もう一度押すと、その時のフレーム数が表示され続ける（前回のフレーム数は表示されない）
        Observable.EveryUpdate()
            .Where(_ => Input.GetKeyDown(KeyCode.A))
            .Select(_ => Time.frameCount)
            .Select(x => Observable.IntervalFrame(60).Do(_ => Debug.Log(x)))
            .Switch()
            .Subscribe()
            .AddTo(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
