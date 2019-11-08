using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

//NextFrame是一个Observable，初始化自己一帧
public class NextFrameExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(Time.frameCount);
        //StartCoroutine(NextFrame(() => Debug.Log(Time.frameCount)));
        Observable.NextFrame().Subscribe(_ => print(Time.frameCount));

    }

    IEnumerator NextFrame(Action callback)
    {
        yield return new WaitForEndOfFrame();

        callback();
    }
}
