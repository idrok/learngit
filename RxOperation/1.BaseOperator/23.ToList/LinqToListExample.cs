using System.Linq;
using UnityEngine;

public class LinqToListExample : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var fruits = new[] {"apple", "orange", "banana", "pineapple"};
        fruits.Select(_ => _.Length).ToList()
            .ForEach(_ => print(_));
    }

    // Update is called once per frame
    private void Update()
    {
    }
}