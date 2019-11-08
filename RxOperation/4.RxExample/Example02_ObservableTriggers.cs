using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class Example02_ObservableTriggers : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        this.UpdateAsObservable()
            .SampleFrame(30)
            .Subscribe(
                _ => print("sample 30 trigger"),
                _ => print("destroy")
                );

        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}