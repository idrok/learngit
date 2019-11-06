using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// 从start开取length长度的递增值
public class LinqRangeExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //start length
        Enumerable.Range(5, 10).Select(x => x *x)
            .ToList()
            .ForEach(_ => { print(_); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
