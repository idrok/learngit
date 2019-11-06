using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UniRx;
using UnityEngine;
using Zenject;

public class CharactorMoveHandler : IFixedTickable, IInitializable
{
    readonly CharactorView _charactor;
    readonly CharactorRotationHandler _rotationHandler;
    //[Inject]
    //readonly SimpleTouchController _touchController;
    [Inject]
    private readonly LeftJoystick leftJoystick;

    Vector2 _touchValue;
    float _moveSpeed = 10;
    private Vector3 leftJoystickInput;

    public Vector3 DestinationPos
    {
        get; set;
    }

    public CharactorMoveHandler(
        CharactorView charactor,
        CharactorRotationHandler rotationHandler
        )
    {
        _charactor = charactor;
        _rotationHandler = rotationHandler;
    }

    public void FixedTick() { }

    public void FixedTickRx()
    {
        // get input from both joysticks
        leftJoystickInput = leftJoystick.GetInputDirection();

//        Debug.Log("magnitude:" + leftJoystickInput.magnitude);

        float xMovementLeftJoystick = leftJoystickInput.x; // The horizontal movement from joystick 01
        float zMovementLeftJoystick = leftJoystickInput.y; // The vertical movement from joystick 01

        //Debug.Log(xMovementLeftJoystick + "," + zMovementLeftJoystick);

        // if there is no input on the left joystick
        if (leftJoystickInput == Vector3.zero)
        {
            _charactor.SetAnimatorRun(0);
        }

        // if there is only input from the left joystick
        if (leftJoystickInput != Vector3.zero)
        {
            // calculate the player's direction based on angle
            // Joystick的取值范围在[-1,1]，这个取值可以直接使用三角函数来处理
            // 如果不是这个取值的话，那么!得想办法转换过来
            // 这里计算的是joystick的平面角度，也就是应该给3d人物投影的角度
            float tempAngle = Mathf.Atan2(zMovementLeftJoystick, xMovementLeftJoystick);
            //var deg = tempAngle * Mathf.Rad2Deg;
            //Debug.Log("deg:" + deg);

            //Mathf.Atan(1f) 传入的是正切值，也就是正切的计算结果，比如1，计算输出依然是弧度
            //为什么到处用弧度来表示角度，因为角度来计算会出现一些争仪，[0,180][-180,0]
            //这样子的话需要转换来表示一个完整的360度
            //Debug.Log("45:" + Mathf.Atan(1f) * Mathf.Rad2Deg);

            //因为R是固定长度，所以角度可以表示在单轴上增量
            //cos一般表示x轴的增量，sin是y轴增量，这里是z轴代表y轴
            //运算符是*=，并且必须是*=，因为这是增量运动计算，根据Joystick的移动力度来对应移动速度
            //这里仅仅是计算joystick在x轴上的增量值和y轴的增量值
            xMovementLeftJoystick *= Mathf.Abs(Mathf.Cos(tempAngle));
            zMovementLeftJoystick *= Mathf.Abs(Mathf.Sin(tempAngle));

            //Debug.Log("Cos:" + Mathf.Cos(tempAngle));
            //Debug.Log("Sin:" + Mathf.Sin(tempAngle));

            leftJoystickInput = new Vector3(xMovementLeftJoystick, 0, zMovementLeftJoystick);
            // 因为_charactor本身可能进行过旋转缩放，导致本身的坐标和世界的坐标不一致
            // 需要把角色向量的方向同当前joystick绑定到一起，为什么向量方向变了而角色不旋转呢？
            // 这类变换的是_charactor的z轴方向并不是rotation变量
            // 如果不进行转换，有可能z轴并不是真正的z轴，虽然在移动，但方向并不是
            leftJoystickInput = _charactor.transform.TransformDirection(leftJoystickInput);
            leftJoystickInput *= 10f;

            // rotate the player to face the direction of input
            Vector3 temp = _charactor.transform.position;
            temp.x += xMovementLeftJoystick;
            temp.z += zMovementLeftJoystick;
            Vector3 lookDirection = temp - _charactor.transform.position;
            if (lookDirection != Vector3.zero)
            {
                _charactor.RotationBody.localRotation = Quaternion.Slerp(_charactor.RotationBody.localRotation,
                    Quaternion.LookRotation(lookDirection), 10f * Time.deltaTime);
            }

            _charactor.SetAnimatorRun(1);
            _charactor.transform.Translate(leftJoystickInput * Time.fixedDeltaTime);
        }
    }

    public void Initialize()
    {
        //_touchController.GameInput += PlayerTouchEvent;
        Observable.EveryUpdate().Subscribe(_ =>
        {
            FixedTickRx();
        });
    }

    private void PlayerTouchEvent(Vector2 value)
    {
        _touchValue = value;
        //_rotationHandler.DesiredVector2 = value;
        //Lengglxyz1 847140
    }
}
