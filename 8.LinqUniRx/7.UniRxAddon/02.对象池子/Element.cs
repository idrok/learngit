using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace UniRx.Addon
{
    public class Element : MonoBehaviour
    {
        // Start is called before the first frame update
        void OnEnable()
        {
            var x = (Random.value - 0.5f) * 20f;
            var y = (Random.value - 0.5f) * 20f;

            transform.position = new Vector3(x, y, 0);
        }

        public IObservable<Unit> ActionAsync()
        {
            Debug.Log("what is the fuck!");

            for (int i = 0; i < 10000; i++)
            {
                if (i % 2 == 0)
                GameObject.CreatePrimitive(PrimitiveType.Cube);
            }
            
//
//            ObservableWWW.Get("http://www.google.com.hk/")
//                .Timeout(TimeSpan.FromSeconds(10))
//                .Subscribe(x =>
//                {
//                    Debug.Log(x);
//                }, ex =>
//                {
//                    Debug.LogError(ex.ToString());
//                });

            return Observable.Timer(TimeSpan.FromSeconds(10)).AsUnitObservable();
        }
    }


}

