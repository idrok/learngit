using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

//Skip 和Take一起忽略前多少个元素，一个是取前多少个元素
public class LinqSkipExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var grades = new[] { 99, 100, 99, 50, 100, 10 };
        grades.OrderByDescending(x => x)
            .Skip(2)
            .ToList()
            .ForEach(_ => print(_));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
