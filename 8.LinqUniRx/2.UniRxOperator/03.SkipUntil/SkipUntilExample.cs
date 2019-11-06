using System.Collections;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

// 仅当达到 什么条件 下才开始执行
// 一直忽略直到条件成立开始执行下面的部分
public class SkipUntilExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var clickStream = this.UpdateAsObservable().Where(_ => Input.GetMouseButtonDown(0));

        this.UpdateAsObservable()
            .SkipUntil(clickStream)
            .Take(100)
            //.Repeat()
            .Subscribe(_ => print("mouse clicked:" + _));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
