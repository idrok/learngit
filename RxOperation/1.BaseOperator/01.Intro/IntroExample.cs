using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class IntroExample : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var students = new List<Student>();
        students.Add(new Student(10, "小明"));
        students.Add(new Student(30, "小胖"));
        students.Add(new Student(20, "小子"));

//        students.ForEach(student=> print(student.ToString()));

//        students.Where(student => student.Age > 20)
//            .ToList()
//            .ForEach(student => print(student.ToString()));
        

    }
}

public class Student
{
    public Student(int age, string name)
    {
        Age = age;
        Name = name;
    }

    public int Age { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        return Name + ":" + Age;
    }
}