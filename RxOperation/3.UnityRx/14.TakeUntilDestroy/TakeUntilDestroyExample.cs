using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class TakeUntilDestroyExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .TakeUntilDestroy(this)
            .Subscribe(_ => print("clicked"));

        Observable.TimerFrame(300).Do(_ => Destroy(this.gameObject)).Subscribe();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
