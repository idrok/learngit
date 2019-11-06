using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// GroupBy .. into 对流数据进行分组
public class UniRxGroupByExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var subject = new Subject<int>();

//        subject.GroupBy(number => number % 2 == 0 ? "双" : "单")
//            .Subscribe(_group =>
//            {
//                _group.Subscribe(_ => { print(_group.Key + ":"+_); });
//            });

        (from number in subject
                group number by number % 2 == 0 ? "偶数" : "奇数" into numberGroup
                select numberGroup)
            .Subscribe(numberGroup =>
            {
                numberGroup.Subscribe(number =>
                {
                    Debug.LogFormat("GroupKey:{0} Number:{1}", numberGroup.Key, number);
                });
            });

        subject.OnNext(1);
        subject.OnNext(2);
        subject.OnNext(3);
        subject.OnNext(4);
        subject.OnNext(5);
        subject.OnCompleted();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
