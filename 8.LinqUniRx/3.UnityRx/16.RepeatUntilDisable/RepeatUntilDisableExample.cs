using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class RepeatUntilDisableExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.Timer(TimeSpan.FromSeconds(1.0f))
            .RepeatUntilDisable(this)
            .Subscribe(_ => Debug.Log("clicked"), () => Debug.Log("completed"));

        Observable.TimerFrame(300).Do(_ => this.gameObject.SetActive(false)).Subscribe();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
