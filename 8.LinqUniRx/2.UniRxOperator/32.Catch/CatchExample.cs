using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// exception catch
public class CatchExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.Throw<string>(new Exception("error"))
            .Catch<string, Exception>(e =>
            {
                Debug.LogFormat("catched excpetion:{0}", e.Message);
                return Observable.Timer(TimeSpan.FromSeconds(1.0f))
                    .Select(_ => "timer called");
            })
            .Subscribe(result => Debug.Log(result));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
