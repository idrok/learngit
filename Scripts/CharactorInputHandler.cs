using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class CharactorInputHandler : ITickable, IInitializable
{

    Camera _camera;
    Ray _ray;
    RaycastHit _hit;

    readonly CharactorMoveHandler _moveHandler;

    public CharactorInputHandler(CharactorMoveHandler moveHandler)
    {
        _moveHandler = moveHandler;
    }

    public void Tick()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _ray = _camera.ScreenPointToRay(Input.mousePosition);
            _hit = default(RaycastHit);
            if(Physics.Raycast(_ray, out _hit, 100))
            {
                if(_hit.transform.name == "Plane")
                {
                    var point = _hit.point;

                    _moveHandler.DestinationPos = point;
                }
            }
        }
    }

    public void Initialize()
    {
        if(_camera == null) { _camera = Camera.main; }
    }
}
