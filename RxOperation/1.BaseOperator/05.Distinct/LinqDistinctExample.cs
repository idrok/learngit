using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
// distinct去重复，对象去重复需要重写HashCode方法
public class LinqDistinctExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var students = new List<Student>();
        students.Add(new Student(20, "小子"));
        students.Add(new Student(10, "小明"));
        students.Add(new Student(10, "小明"));
        students.Add(new Student(30, "小胖"));
        students.Add(new Student(20, "小子"));
        students.Add(new Student(10, "小明"));
        students.Add(new Student(30, "小胖"));
        students.Add(new Student(20, "小子"));

        students.Distinct(new StudentComparer()).ToList()
        .ForEach(_distinctStudent => { print(_distinctStudent.ToString()); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            return x.Age == y.Age && x.Name == y.Name;
        }

        public int GetHashCode(Student obj)
        {
            var toHashString = $"{obj.Name}_{obj.Age}";
            return toHashString.GetHashCode();
        }
    }
}
