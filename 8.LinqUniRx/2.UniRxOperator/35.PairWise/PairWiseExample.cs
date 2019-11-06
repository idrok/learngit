using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// PairWise是串流的ForEach遍历
public class PairWiseExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.Range(0, 3)
            .Pairwise()
            .Subscribe(pair => Debug.LogFormat("{0}:{1}", pair.Previous, pair.Current));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
