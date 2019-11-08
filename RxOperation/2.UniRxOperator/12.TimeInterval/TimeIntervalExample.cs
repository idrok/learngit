using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// 监听做某一事的频率，进行事件换算
// 类似的有Interval() Repeat()重复一个流的执行部分
public class TimeIntervalExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Select(_ => "clicked")
            .TimeInterval()
            .Subscribe(_ => print(_.Interval + ":" + _.Value));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
