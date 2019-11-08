using System.Collections;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

// 将多个Observable结合到一起组合数据并且取最新的数据
public class CombineLatest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var a = 0;
        var i = 0;

        var leftStream = this.UpdateAsObservable().Where(_ => Input.GetMouseButtonDown(0))
            .Select(_ => (++a).ToString());
        var rightStream = this.UpdateAsObservable().Where(_ => Input.GetMouseButtonDown(1))
            .Select(_ => (++i).ToString());
        leftStream.CombineLatest(rightStream, (l, r) => l + r)
            .Subscribe(print);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
