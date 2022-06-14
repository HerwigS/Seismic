using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParametersPeer : MonoBehaviour
{
    public Vector3 _GlobalPosition;
    public Vector3 _GlobalScale;
    public static float _AvatarPositionX;
    public static float _AvatarPositionY;
    public static float _AvatarPositionZ;

    public static float _AvatarScaleX;
    public static float _AvatarScaleY;
    public static float _AvatarScaleZ;

    void Start()
    {
        // Vector3 LocalPosition = gameObject.GetComponent<Transform>().position;
        // Vector3 GloabalPosition = gameObject.transform.position;
    }

    void Update()
    {
        GetGlobalPosition();
        GetGlobalScale();
    }


    void GetGlobalPosition()
    {
        _GlobalPosition = gameObject.transform.position;

        _AvatarPositionX = _GlobalPosition.x;
        _AvatarPositionY = _GlobalPosition.y;
        _AvatarPositionZ = _GlobalPosition.z;
    }

    void GetGlobalScale()
    {
        _GlobalScale = gameObject.transform.localScale;
        _AvatarScaleX = _GlobalScale.x;
        _AvatarScaleY = _GlobalScale.y;
        _AvatarScaleZ = _GlobalScale.z;
    }
}