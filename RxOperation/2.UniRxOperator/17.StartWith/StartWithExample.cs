using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// 将数据加入前缀
public class StartWithExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.Return("qq.com")
            .StartWith("http", "://")
            .Aggregate((current, next) => current + next)
            .Subscribe(print);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
