using UniRx;
using UnityEngine;

// zip连接两个操作，其作用相当于WhenAll，但Zip是聚合操作
// 可以对结果任何处理
public class UniRxZipExample : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var leftMouse = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0));
        var rightMouse = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(1));
        leftMouse.Zip(rightMouse, (left, right) => Unit.Default)
            .Subscribe(_ => print("ok"));
    }

    // Update is called once per frame
    private void Update()
    {
    }
}