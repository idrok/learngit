using System.Collections.Generic;
using System.Linq;
using UnityEngine;

//类似 compator 接口，用于当前数据和下一个数据对比
public class LinqAggregateExample : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var ages = new[] {11, 22, 33, 44, 55, 66, 77};
        var result = ages.Aggregate((minAge, nextAge) => minAge > nextAge ? nextAge : minAge);
        print(result);

//        var words = new String[] {"hello", "world", "not", "simple"};
//        var english = words.Aggregate((per, next) => per + "_" + next);
//        print(english);

        AdvanceFunc();
    }

    private void AdvanceFunc()
    {
        var list = new List<temp>
        {
            new temp {A = 1, B = 1, C = "a"},
            new temp {A = 1, B = 2, C = "a"},
            new temp {A = 1, B = 3, C = "a"},
            new temp {A = 1, B = 4, C = "b"},
            new temp {A = 1, B = 5, C = "a"},
            new temp {A = 2, B = 6, C = "a"},
            new temp {A = 2, B = 7, C = "b"},
            new temp {A = 2, B = 8, C = "b"}
        };
        var result = new List<temp>();
        list.Aggregate((pre, next) =>
        {
            if (pre.A == next.A && pre.C == next.C)
            {
                if (pre.B == next.B - 1)
                {
                    result.Add(pre);
                    result.Add(next);
                    return next;
                }
                else
                {
                    return pre;
                }
                
            }
            else
            {
                return next;
            }
        });

        result.Distinct().ToList().ForEach(x => print(x.ToString()));
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private class temp
    {
        public int A { get; set; }
        public int B { get; set; }
        public string C { get; set; }

        public override string ToString()
        {
            return A +" " + B + " "+ C;
        }
    }
}