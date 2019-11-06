using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LinqSingleExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var students = new List<Student>();
        students.Add(new Student(15, "AAA"));
        students.Add(new Student(10, "BBB"));
        students.Add(new Student(13, "CCC"));
        students.Add(new Student(12, "DDD"));

        var student = students.Single(_ => _.Age == 15);
        print(student);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
