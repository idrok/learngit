using UnityEngine;
using System.Collections;
using UniRx;
using UniRx.Triggers;

namespace UniRxWorkBook.Operators
{

    public class Answer_Lesson_1_Subscribe : MonoBehaviour
    {
        private void Start()
        {
            // UniRx.Triggerを追加することでthis.UpdateAsObservable()でUpdate()をストリームとして扱うことができるようになる
            // あとはそれをSubscribeし、毎フレームCubeが回転するようになる

            /*
             * 添加了unirx.trigger，可以通过this.updateasobservable()可以将update当作流处理。
             * 然后是subscribe，每个帧cube会旋转
             */
            this.UpdateAsObservable().Subscribe(_ => RotateCube());

            //ちなみにラムダ式の左辺に _ を使っているが、これは「デリゲート内でこの引数を使うことはない」という意味である
            // 顺便说一下，他使用的是，尽管它使用的是，但它并没有使用这个参数。
        }

        private void RotateCube()
        {
            this.transform.rotation = Quaternion.AngleAxis(1.0f, Vector3.up)*this.transform.rotation;
        }
    }

}
