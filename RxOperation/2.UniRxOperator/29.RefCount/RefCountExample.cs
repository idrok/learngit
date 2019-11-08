using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

//???让一个可连接的Observable行为像普通的Observable
//???
public class RefCountExample : MonoBehaviour
{
    IEnumerator Start()
    {
        var oneSecondPeriod = TimeSpan.FromSeconds(1.0f);

        var refCountObservable = Observable.Interval(oneSecondPeriod)
            .Do(l => Debug.LogFormat("Publishing {0}", l))
            .Publish()
            .RefCount();

        var subscription1 = refCountObservable.Subscribe(l => Debug.LogFormat("subscription #1 : {0}", l));

        //yield return new WaitForSeconds(5.0f);


        var subscription2 = refCountObservable.Subscribe(l => Debug.LogFormat("subscription #2  : {0}", l));


        yield return new WaitForSeconds(3.0f);

        subscription1.Dispose();

        yield return new WaitForSeconds(1.0f);

        subscription2.Dispose();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
