using System.Linq;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace UniRxWorkBook.Operators
{
    public class Lesson_5_Buffer : MonoBehaviour
    {
        [SerializeField] private Button buttonA;
        [SerializeField] private Button buttonB;
        [SerializeField] private Button buttonC;
        [SerializeField] private Text resultLabel;

        private void Start()
        {
            var aStream = buttonA.OnClickAsObservable().Select(_ => "A");
            var bStream = buttonB.OnClickAsObservable().Select(_ => "B");
            var cStream = buttonC.OnClickAsObservable().Select(_ => "C");

            // _____()を書き換え、
            // 過去３回分の押されたボタンの履歴を表示してみよう
            // （３回押される度に更新される仕様で良い）
            aStream.Merge(bStream, cStream)
                .Buffer(3)
                .SubscribeToText(resultLabel, x => x.Aggregate((p, c) => p + c));

            // IEnmerable<String>を１つのStringに合成するなら
            // strings.Aggregate((p, c) => p + c) とAggregateを使うと簡単に書ける
        }
    }
}