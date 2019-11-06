using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinqToArrayExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var nums = new List<int> {1, 2, 3, 4, 5, 6};
        var array = nums.ToArray();
        Array.ForEach(array, _=> print(_));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
