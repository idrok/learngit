using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// WhenAll 当流操作中拥有多个流操作，当子流全部完成时调用
public class UniRxWhenAllExample : MonoBehaviour
{
    IEnumerator A()
    {
        yield return new WaitForSeconds(1);
        print("A");
    }

    IEnumerator B()
    {
        yield return new WaitForSeconds(1);
        print("B");
    }

    // Start is called before the first frame update
    void Start()
    {
        var a = Observable.FromCoroutine(A);
        var b = Observable.FromCoroutine(B);
        var c = Observable.EveryUpdate().Where(_event => Input.GetMouseButtonDown(0))
            .Take(5).Select(_ =>
            {
                print("mouse down");
                return Unit.Default;
            });
        Observable.WhenAll(a, b, c)
            .Subscribe(_ => { print("AllFininsh"); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
