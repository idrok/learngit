using UniRx;
using UnityEngine;

//OfType 筛选一个类型的流数据
public class UniRxOfTypeExample : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        //        var subject = new Subject<Base>();
        //        subject.OfType<Base, A>()
        //            .Subscribe(_ => { print(_.Name); });
        //
        //        
        //        subject.OnNext(new A {Name = "A"});
        //        subject.OnNext(new B {Name = "B"});
        //        subject.OnNext(new A {Name = "A"});
        //        subject.OnCompleted();

        var subject = new Subject<int>();
        subject.OfType<int, int>()
            .Subscribe(_ => { print(_); });


        subject.OnNext(1);
        subject.OnNext(2);
        subject.OnNext(3);
        subject.OnCompleted();


    }

    // Update is called once per frame
    private void Update()
    {
    }

    public class Base
    {
        public string Name { get; set; }
    }

    public class A : Base
    {
    }

    private class B : Base
    {
    }
}