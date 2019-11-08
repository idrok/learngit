using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class Example10_MainThreadDispatcher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        new Runnable().Run();
    }
    

    class Runnable
    {
        public void Run()
        {
            // two way start coroutine beside mono
            MainThreadDispatcher.StartCoroutine(TestAsync());
            Observable.FromCoroutine(TestAsync).Subscribe();
            
            // 在非主线程执行主线程
            MainThreadDispatcher.Post(_ => print(_.ToString()), "gameplay");

            // 所有基于时间或者帧操作的函数主线程执行
            Observable.IntervalFrame(66).Subscribe(_ => print(_));

            // start()会开启新线程
            Observable.Start(() => Unit.Default)
                .ObserveOnMainThread()
                .Subscribe(_ => print(_), exception => print(exception.StackTrace));
        }

        IEnumerator TestAsync()
        {
            Debug.Log("a");
            yield return new WaitForSeconds(1);
            Debug.Log("b");
            yield return new WaitForSeconds(1);
            Debug.Log("c");
            yield return new WaitForSeconds(1);
            Debug.Log("d");
        }
    }
}
