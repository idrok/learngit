using UniRx;
using UnityEngine;

// 帧时间间隔
public class FrameTimeIntervalExample : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .FrameTimeInterval()
            .Subscribe(_ => print(_));
    }

    // Update is called once per frame
    private void Update()
    {
    }
}