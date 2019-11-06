using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class TimestampExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Timestamp()
            .Subscribe(_ => print(_.Timestamp.ToLocalTime()));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
