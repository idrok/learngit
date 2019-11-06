using System.Collections.Generic;
using System.Linq;
using UnityEngine;

//Concat 连接两个List
public class LinqConcatExample : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var students1 = new List<Student>();
        students1.Add(new Student(15, "AAA"));
        students1.Add(new Student(10, "BBB"));

        var students2 = new List<Student>();
        students2.Add(new Student(13, "CCC"));
        students2.Add(new Student(12, "DDD"));

        students1.Concat(students2).ToList()
            .ForEach(_student => { print(_student.ToString()); });
    }

    // Update is called once per frame
    private void Update()
    {
    }
}