using System;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

// CompositeDisposable可以手动管理订阅者的生命周期
// Subject一般用于表达事件
public class Example09_EventHanding : MonoBehaviour
{
    private readonly Subject<int> _onBarBar = new Subject<int>();
    private readonly CompositeDisposable disposable = new CompositeDisposable();

    public IObservable<int> OnBarBar => _onBarBar;

    public event Action<int> FooFoo;

    // Start is called before the first frame update
    private void Start()
    {
        Observable.FromEvent<int>(
                h => FooFoo += h, h => FooFoo -= h)
            .Subscribe(_ => print(_))
            .AddTo(disposable);

        if (FooFoo != null) FooFoo(100);

        OnBarBar.Subscribe(_ => print(_)).AddTo(disposable);
        _onBarBar.OnNext(100);
        _onBarBar.OnCompleted();// OnCompleted表示主题演出结束了
        _onBarBar.OnNext(110);

        this.OnDestroyAsObservable().Subscribe(_ => disposable.Dispose());
    }

    
}