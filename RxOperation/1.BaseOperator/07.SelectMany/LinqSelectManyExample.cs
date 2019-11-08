using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
// 多个复合数据查询，当一个对象里面有引用List的时候好用
public class LinqSelectManyExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var students = new List<Student>();
        students.Add(new Student(20, "小子"));
        students.Add(new Student(10, "小明"));
        students.Add(new Student(30, "小胖"));
        students.Add(new Student(10, "小猫"));

//        students.SelectMany(_student => _student.Name)
//            .ToList()
//            .ForEach(_ =>
//            {
//                print(_);
//            });
        var query = from student in students select student.Name.ToCharArray();
        query.ToList()
            .ForEach(_ => { print(_); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
