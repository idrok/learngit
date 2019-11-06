using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class NeverExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var observable = Observable.Never<string>();
        observable.Subscribe(_ => print("onnext"), _ => print("oncomplete"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
