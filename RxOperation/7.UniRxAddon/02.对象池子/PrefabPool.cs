using System.Collections;
using System.Collections.Generic;
using UniRx.Toolkit;
using UnityEngine;
using UnityEngine.UI;

namespace UniRx.Addon
{
    public class PrefabPool : MonoBehaviour
    {
        [SerializeField]
        private Button mButton;
        [SerializeField]
        private Button mClear;

        public Element mPrefab;

        private ElementPool mPool;

        // Start is called before the first frame update
        void Start()
        {
            mPool = new ElementPool(mPrefab, this.transform);

            mButton.OnClickAsObservable().Subscribe(_ =>
            {
                var element = mPool.Rent();
                element.ActionAsync().Subscribe(__ =>
                {
                    mPool.Return(element);
                });
            });

            mClear.OnClickAsObservable().Subscribe(_ =>
            {
                mPool.Clear();
            });
            
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public class ElementPool : ObjectPool<Element>
    {
        private readonly Element mPrefab;
        private readonly Transform mHierarchyParent;

        public ElementPool(Element prefab, Transform hierarchyParent)
        {
            this.mPrefab = prefab;
            this.mHierarchyParent = hierarchyParent;
        }

        protected override Element CreateInstance()
        {
            var element = Object.Instantiate<Element>(mPrefab);
            element.transform.SetParent(mHierarchyParent);

            return element;
        }

        protected override void OnBeforeRent(Element instance)
        {
            instance.gameObject.SetActive(true);
            Debug.Log("OnBeforeRent:" + instance.name);
        }

        protected override void OnBeforeReturn(Element instance)
        {
            instance.gameObject.SetActive(false);
            Debug.Log("OnBeforeReturn:" + instance.name);
        }

        protected override void OnClear(Element instance)
        {
            base.OnClear(instance);
            Debug.Log("OnClear:" + instance.name);
        }
    }
}

