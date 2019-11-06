using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LinqRepeatExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Enumerable.Repeat("i am ok!", 10)
            .ToList()
            .ForEach(print);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
