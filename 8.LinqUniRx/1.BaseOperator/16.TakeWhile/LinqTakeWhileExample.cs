using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

//当满足条件的时候，我就take，只要一遇到不满足条件的就跳过
public class LinqTakeWhileExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var students = new List<Student>();
        students.Add(new Student(15, "AAA"));
        students.Add(new Student(10, "BBB"));
        students.Add(new Student(13, "CCC"));
        students.Add(new Student(12, "DDD"));

        students.TakeWhile(_ => _.Age > 11)
            .ToList()
            .ForEach(print);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
