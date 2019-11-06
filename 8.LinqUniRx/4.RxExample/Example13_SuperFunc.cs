using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

// Merge弱合并两个事件流，事件可有可无
public class Example13_SuperFunc : MonoBehaviour
{
    [SerializeField] private Button _addButton;
    [SerializeField] private Button _clearButton;
    [SerializeField] private InputField _inputField;
    [SerializeField] private Text _numsText;
    [SerializeField] private GameObject _itemPrefab;
    [SerializeField] private Transform _listTransform;

    // 这就是官方说明的反应堆，这是RX的核心，也就是“响应式”编程
    // 非常标准的MVC，数据驱动显示
    private readonly ReactiveCollection<GameObject> _reactives = new ReactiveCollection<GameObject>();

    void Start()
    {
        var submit = Observable.Merge(_addButton.OnClickAsObservable().Select(_=>_inputField.text),
        _inputField.OnEndEditAsObservable().Where(_ => Input.GetKeyDown(KeyCode.Return)));

        submit.Where(_ => _ != "")
            .Subscribe(_ =>
            {
                _inputField.text = "";
                var item = Instantiate(_itemPrefab);
                item.GetComponentInChildren<Text>().text = _;
                _reactives.Add(item);
            });

        _reactives.ObserveCountChanged().Subscribe(_ => _numsText.text = "Count:" + _.ToString());

        _reactives.ObserveAdd().Subscribe(_ =>
        {
            _.Value.SetActive(true);
            _.Value.transform.SetParent(_listTransform, false);
        });

        _reactives.ObserveRemove().Subscribe(_ =>
        {
            GameObject.Destroy(_.Value);
        });

        _clearButton.OnClickAsObservable().Subscribe(_ =>
        {
            var removes = _reactives.Where(__ => __.GetComponent<Toggle>().isOn);
            removes.ToList().ForEach(___ => _reactives.Remove(___));
        });
    }
}
