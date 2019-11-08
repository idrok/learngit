using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LinqEmptyExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var empty = Enumerable.Empty<string>().ToList();
        print(empty.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
