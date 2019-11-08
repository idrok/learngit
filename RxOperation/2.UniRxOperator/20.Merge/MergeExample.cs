using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// Merge将多个事件流进行合并，仅合并流，不影响单个流执行结果
// 类似的方法有：CombineLatest SelectMany
public class MergeExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var leftClickStream = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0)).Select(_ => "A");
        var rightClickStream = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(1)).Select(_ => "B");

        leftClickStream.Merge(rightClickStream)
            .Subscribe(print);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
