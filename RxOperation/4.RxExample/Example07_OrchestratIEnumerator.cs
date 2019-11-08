using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class Example07_OrchestratIEnumerator : MonoBehaviour
{
    IEnumerator AsyncA()
    {
        print("a start");
        yield return new WaitForSeconds(3);
        print("a end");
    }

    IEnumerator AsyncB()
    {
        print("b start");
        yield return new WaitForEndOfFrame();
        print("b end");
    }
    
    void Start()
    {
        var asyncA = AsyncA();
        var asyncB = AsyncB();
        var observableA = asyncA.ToObservable();
        var observableB = asyncB.ToObservable();

//        observableA.Merge(observableB).Subscribe();
        observableA.SelectMany(observableB).Subscribe();
        //var cancel = Observable.FromCoroutine(AsyncA).SelectMany(AsyncB).Subscribe();

    }
}
