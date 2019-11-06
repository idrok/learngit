using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LinqFirstExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var students = new List<Student>();
        students.Add(new Student(10, "小明"));
        students.Add(new Student(30, "小胖"));
        students.Add(new Student(20, "小子"));

        //        var student = students.First();
        //        print(student.ToString());
        //        var student = students.First(_student => _student.Age == 20);
        //        print(student.ToString());

//        var query = from _student in students select _student;
//        var student = query.First(_student => _student.Age == 10);
//        print(student.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
