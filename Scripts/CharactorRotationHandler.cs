using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class CharactorRotationHandler : IFixedTickable
{ 
    readonly CharactorView _view;
    public CharactorRotationHandler(CharactorView view)
    {
        _view = view;
    }

    public Vector3 DesiredLookDir { get; set; }

    public  Vector2 DesiredVector2 { get; set; }

    public void FixedTick()
    {
        if (DesiredVector2.magnitude > 0)
        {
            //_view.Rotation = Quaternion.LookRotation(DesiredLookDir, _view.Up);
            //DesiredLookDir = Vector3.zero;
            //_view.transform.localRotation = Quaternion.Euler(DesiredLookDir);
            //45 -135
//            var  qua =Quaternion.Euler(_view.transform.localEulerAngles.x - DesiredVector2.y * Time.deltaTime * 1000f,
//                             _view.transform.localEulerAngles.y + DesiredVector2.x * Time.deltaTime * 1000f,0);
//            _view.Rotation = qua;
        }
    }
}
