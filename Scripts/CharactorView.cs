using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorView : MonoBehaviour
{
    [SerializeField]
    Animator _animator;

    [SerializeField]
    SkinnedMeshRenderer _renderer;

    [SerializeField]
    private Transform _rotationBody;

    public Transform RotationBody => _rotationBody;

    public SkinnedMeshRenderer Renderer
    {
        get{ return _renderer; }
    }

    public Animator Animator
    {
        get{return _animator;}
    }

    public Vector3 Forward
    {
        get { return transform.forward; }
    }

    public Vector3 Right => transform.right;

    public Vector3 Up
    {
        get { return transform.up; }
    }

    public Vector3 Position
    {
        get => transform.position;
        set => transform.position = value;
    }

    public Quaternion Rotation
    {
        get{return transform.rotation;}
        set{transform.rotation = value;}
    }

    public void SetAnimatorRun(float value)
    {
        _animator.SetFloat("Run", value);
    }
}
