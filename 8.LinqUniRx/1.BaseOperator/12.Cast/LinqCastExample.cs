using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

//???
public class LinqCastExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var students = new List<Student>();
        students.Add(new Student(15, "AAA"));
        students.Add(new Student(10, "BBB"));
        students.Add(new Student(13, "CCC"));
        students.Add(new Student(12, "DDD"));

        ArrayList lists = new ArrayList() { 1, 2, 3, "zz", "yy", "xx" };
        lists.Cast<string>()
            .Select(_ => _.ToString())
            .ToList()
            .ForEach(print);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
