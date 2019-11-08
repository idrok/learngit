using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class TakeUntilDisableExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Do(_ => Debug.Log("do mouse button downed"))
            .TakeUntilDisable(this)
            .Subscribe(_ => Debug.Log("mouse clicked"));

        Observable.TimerFrame(300).Do(_ => this.gameObject.SetActive(false)).Subscribe();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
