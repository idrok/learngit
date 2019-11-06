using System.Collections;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.UI;

public class Example03_GameObjectAsObservable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //非常好的示例，由一个按下可以拓展到全屏鼠标获取
        //可以当一个拖拽功能来使用，UniRx真不一样
        this.OnMouseDownAsObservable()
            .SelectMany(_ => this.gameObject.UpdateAsObservable())
            .TakeUntil(this.gameObject.OnMouseUpAsObservable())
            .Select(_ => Input.mousePosition)
            .RepeatUntilDestroy(this)
            .Subscribe(_ => print(_), _ => print("!!!ok"));
    }
}
