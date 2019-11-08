using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WhereExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var students = new List<Student>();
        students.Add(new Student(10, "小明"));
        students.Add(new Student(30, "小胖"));
        students.Add(new Student(20, "小子"));

//        students.Where(x => x.Age > 9).ToList().ForEach(y => print(y.ToString()));

        var query = from student in students where student.Age > 10 select student;
        query.ToList().ForEach(student =>
        {
            print(student.ToString());
        });

    }
}
