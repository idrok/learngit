using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// SeletMany 一次流操作中返回多个处理结果
public class UniRxSelectManyExample : MonoBehaviour
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

    IEnumerator C()
    {
        yield return new WaitForSeconds(1);
        print("C");
    }

    // Start is called before the first frame update
    void Start()
    {
        var a = Observable.FromCoroutine(A);
        var b = Observable.FromCoroutine(B);
        var c = Observable.FromCoroutine(C);

        a.SelectMany(b.SelectMany(c)).Subscribe();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
