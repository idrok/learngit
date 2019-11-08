using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

//OfType 筛选获取一种类型
public class LinqOfTypeExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var students = new List<Student>();
        students.Add(new Student(15, "AAA"));
        students.Add(new Student(10, "BBB"));
        students.Add(new Student(13, "CCC"));
        students.Add(new Student(12, "DDD"));

        ArrayList lists = new ArrayList() { 1,2,3,"zz","yy","xx"};

        lists.OfType<int>()
            .ToList()
            .ForEach(_ => { print(_); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
