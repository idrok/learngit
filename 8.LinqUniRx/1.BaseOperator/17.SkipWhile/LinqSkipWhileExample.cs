using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

//takewhile 取连续满足条件数据的值，跳过数据不满足的值
//skipwhile 连续跳过满足条件的值，取数据不满足的值
//take skip都是从第一个元素开始计算有效值
//take（取值） skip（跳值）
//skip（跳值） take（取值） 构成数据分离
public class LinqSkipWhileExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        new[] { 1, 2, 3, 4, 5, 6, 7, 8 }
            //.OrderBy(grade => grade)
            .SkipWhile(_ => _ < 4)
            .ToList()
            .ForEach(_ => print(_));

        new[] { 1, 2, 3, 4, 5, 6, 7, 8 }
            //.OrderBy(grade => grade)
            .TakeWhile(_ => _ > 4)
            .ToList()
            .ForEach(_ => print(_));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
