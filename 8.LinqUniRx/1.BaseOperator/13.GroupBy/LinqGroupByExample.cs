using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

//基于分类来分组数据 ?
public class LinqGroupByExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var students = new List<Student>();
        students.Add(new Student(15, "AAA"));
        students.Add(new Student(10, "BBB"));
        students.Add(new Student(13, "CCC"));
        students.Add(new Student(12, "DDD"));
        students.Add(new Student(15, "EEE"));
        students.Add(new Student(10, "FFF"));
        students.Add(new Student(15, "AAA"));
        students.Add(new Student(10, "BBB"));
        students.Add(new Student(13, "CCC"));
        students.Add(new Student(12, "DDD"));
        students.Add(new Student(15, "EEE"));
        students.Add(new Student(10, "FFF"));

//        students.GroupBy(_student => _student.Age)
//            .ToList()
//            .ForEach(_group =>
//            {
//                _group.ToList().ForEach(_ => { print(_group.Key +"->"+ _.Name+":"+ _.Age); });
//            });

        var query = from student in students group student by student.Age into _group select _group;
            query.ToList()
            .ForEach(_group =>
            {
                _group.ToList().ForEach(_ => { print(_group.Key +"->"+ _.Name+":"+ _.Age); });
            });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
