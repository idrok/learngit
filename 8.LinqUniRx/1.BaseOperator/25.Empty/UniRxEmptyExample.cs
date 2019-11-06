using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class UniRxEmptyExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.Empty<string>()
            .Subscribe(_ => Debug.Log("OnNext"), () => Debug.Log("OnCompleted"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
