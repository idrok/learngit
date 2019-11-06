using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// 等待订阅者订阅，执行全部订阅者
public class DeferExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var deferRandom = new System.Random();
        var deferRangeStream = Observable.Defer((() => Observable.Start(deferRandom.Next)));
        deferRangeStream.Subscribe(_ => print("1 st"));
        deferRangeStream.Subscribe(_ => print("2 st"));

        var random = new System.Random();
        var rangeStream = Observable.Start(random.Next);
        rangeStream.Subscribe(_ => print("3 st"));
        rangeStream.Subscribe(_ => print("4 st"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
