using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

//取一个系列的前多少个元素
public class LinqTakeExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var students = new List<Student>();
        students.Add(new Student(15, "小子"));
        students.Add(new Student(10, "小明"));
        students.Add(new Student(13, "小胖"));
        students.Add(new Student(12, "小猫"));

        students.Take(3).ToList()
            .ForEach(_student=>{print(_student.ToString());});
        
    }
}
