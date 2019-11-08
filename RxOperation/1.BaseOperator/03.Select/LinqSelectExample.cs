using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LinqSelectExample : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var students = new List<Student>();
        students.Add(new Student(10, "小明"));
        students.Add(new Student(30, "小胖"));
        students.Add(new Student(20, "小子"));

//        students.Select(student => student.Age)
//            .ToList()
//            .ForEach(student =>
//            {
//                print(student.ToString());
//            });
        var query = from student in students select student.Age;
        query.ToList().ForEach(age => { print(age); });
    }

    // Update is called once per frame
    private void Update()
    {
    }
}