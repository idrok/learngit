using UnityEngine;
using System.Linq;
using UniRx;
using UniRx.Triggers;

// 一次流操作满足条件的筛选
public class UniRxWhereExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
//            Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0)).Subscribe(_ => { print("mouse down"); })
//                .AddTo(this);
        var query = from frameUpdate in Observable.EveryUpdate() where Input.GetMouseButtonDown(0) select frameUpdate;
        query.Subscribe(_ =>
        {
            print(_ +":mouse down");
        }).AddTo(this);
    }

}


