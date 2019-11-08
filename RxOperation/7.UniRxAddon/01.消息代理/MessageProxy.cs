using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UniRx.Addon
{
    public class MessageProxy : MonoBehaviour
    {
        // Start is called before the first frame update
        void StartNormal()
        {

            MessageBroker.Default.Receive<MSG_UpdateCoin>().Subscribe(x =>
            {
                var coin = x as MSG_UpdateCoin;
                Debug.Log(coin.Value.ToString());
            });

            MessageBroker.Default.Publish(new MSG_UpdateCoin(){ Value = 1000 });


        }

        void Start()
        {
            AsyncMessageBroker.Default.Subscribe<MSG_UpdateCoin>(coin =>
            {
                return Observable.TimerFrame(100).ForEachAsync(_ =>
                {

                    Debug.Log("fun1:" + coin.Value);
                });
            });

            AsyncMessageBroker.Default.Subscribe<MSG_UpdateCoin>(coin =>
            {
                return Observable.TimerFrame(100).ForEachAsync(_ =>
                {

                    Debug.Log("fun2:" + coin.Value);
                });
            });
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonUp(0))
            {
                AsyncMessageBroker.Default.PublishAsync(new MSG_UpdateCoin() { Value = 3000 }).Subscribe();
                AsyncMessageBroker.Default.PublishAsync(new MSG_UpdateCoin() { Value = 4000 }).Subscribe();
                AsyncMessageBroker.Default.PublishAsync(new MSG_UpdateCoin() { Value = 5000 }).Subscribe();
                
            }
        }
    }

    public class MSG_UpdateCoin
    {
        public long Value;
    }


}

