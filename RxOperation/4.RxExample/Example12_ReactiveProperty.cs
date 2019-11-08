using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class Example12_ReactiveProperty : MonoBehaviour
{
    [SerializeField]
    private Button _takeButton;
    [SerializeField]
    private Text _hpNumText;
    [SerializeField]
    private Slider _slider;
    [SerializeField]
    private InputField _input;
    [SerializeField]
    private Toggle _toggle;
    
    Enemy _enemy = new Enemy(1000);

    void Start()
    {
        _takeButton.onClick.AsObservable().Subscribe(_ => _enemy.CurrentHpProperty.Value -= 100);
        _enemy.CurrentHpProperty.SubscribeToText(_hpNumText);
        _enemy.IsDead.Where(idDead => idDead == true)
            .Subscribe(_ => _takeButton.interactable = false);
        _slider.onValueChanged.AsObservable().SubscribeToText(_hpNumText, x => Math.Round(x, 2).ToString());
        _input.OnValueChangedAsObservable()
            .Where(_ => _ != null)
            .Delay(TimeSpan.FromSeconds(1))
            .SubscribeToText(_hpNumText);
        _toggle.OnValueChangedAsObservable().SubscribeToInteractable(_takeButton);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public class Enemy
    {
        public IReactiveProperty<int> CurrentHpProperty { get; private set; }
        public IReadOnlyReactiveProperty<bool> IsDead { get; private set; }

        public Enemy(int initHp)
        {
            CurrentHpProperty = new ReactiveProperty<int>(initHp);
            IsDead = CurrentHpProperty.Select(_ => _ <= 0).ToReactiveProperty();
        }
    }
}
