using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// WhenAll当所有条件满足以后
public class LinqWhenAllExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var students = new List<Student>();
        students.Add(new Student(15, "AAA"));
        students.Add(new Student(10, "BBB"));
        students.Add(new Student(13, "CCC"));
        students.Add(new Student(12, "DDD"));

        var query = students.All(_student => _student.Age > 9);
        print(query);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
