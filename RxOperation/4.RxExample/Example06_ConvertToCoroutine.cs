using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class Example06_ConvertToCoroutine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TestNewCustomYieldInstruction());
    }

    IEnumerator ComplexCoroutineTest()
    {
        yield return new WaitForSeconds(1);

        var v = default(int);
        //wait unirx observable execute over and to do next
        yield return Observable.Range(1, 10).StartAsCoroutine(x => v = x);

        print(v); //10 ok
        yield return new WaitForSeconds(3);

        yield return Observable.Return(100).StartAsCoroutine(x => v = x);
        print(v);//100 ok
    }

    IEnumerator TestNewCustomYieldInstruction()
    {
        yield return Observable.Timer(TimeSpan.FromSeconds(1)).ToYieldInstruction();

        yield return Observable.Timer(TimeSpan.FromSeconds(1), Scheduler.MainThreadIgnoreTimeScale).ToYieldInstruction();

        var o = ObservableWWW.Get("http://qq.com").ToYieldInstruction();
        yield return o;

        if (o.HasError)
        {
            print(o.Error.ToString());
        }

        if (o.HasResult)
        {
            print(o.Result);
        }

        var v = this.ObserveEveryValueChanged(x => x.transform).FirstOrDefault(x => x.position.y >= 100).ToYieldInstruction();
        yield return v;
        if (v.HasResult)
        {
            print(v.Result.position.ToString());
        }
    }
}
