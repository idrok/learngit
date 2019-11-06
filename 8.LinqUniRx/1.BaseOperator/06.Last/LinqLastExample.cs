using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

//Last 最后一个或者最后一个满足条件的
public class LinqLastExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var students = new List<Student>();
        students.Add(new Student(20, "小子"));
        students.Add(new Student(10, "小明"));
        students.Add(new Student(30, "小胖"));
        students.Add(new Student(10, "小猫"));

        //        print(students.Last().ToString());
        print(students.Last(_student => _student.Age == 10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
