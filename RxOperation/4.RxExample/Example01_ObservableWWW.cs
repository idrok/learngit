using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.Networking;

#if UNITY_2018_3_OR_NEWER
#pragma warning disable CS0618
#endif

public class Example01_ObservableWWW : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string url = "http://www.baidu.com";
        string urlUnityAssetStore = "https://assetstore.unity.com/";
//        ObservableWWW.Get(url)
//            .Subscribe(_ =>  print(_));

//        var notifier = new ScheduledNotifier<float>();
//        notifier.Subscribe(_ => print(_));
//        ObservableWWW.Get(urlUnityAssetStore, progress: notifier).Subscribe();

//        var query = from baidu in ObservableWWW.Get(url)
//            from unity in ObservableWWW.Get(urlUnityAssetStore)
//            select new { baidu, unity };
//        var disposable = query.Subscribe(_ => print("baidu:" + _.baidu.Substring(0, 100) + " unity:" + _.unity.Substring(0, 100)));
//        //disposable.Dispose();

        //???
//        Observable.WhenAll<string[]>(
//            ObservableWWW.Get(url),
//            ObservableWWW.Get(urlUnityAssetStore)
//        );

        ObservableWWW.Get("http://www.google.com.hk/").CatchIgnore((WWWErrorException ex) =>
        {
            print(ex.RawErrorMessage);
            if (ex.HasResponse)
            {
                print(ex.StatusCode);
            }

            foreach (var header in ex.ResponseHeaders)
            {
                print(header.Key + ":" + header.Value);
            }
        }).Subscribe(print);
    }
}
