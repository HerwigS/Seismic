using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.VFX;
using UnityEngine.VFX;

public class ParameterVFX : MonoBehaviour
{
    public string PositionX, PositionY, PositionZ;

    public string DistanceRightLeftHandX, DistanceRightLeftHandY;

    public string DistanceToeAndHeadBonesX, DistanceToeAndHeadBonesY;

    VisualEffect visualEffect;
    private DistanceBones DistanceBonesScript;
    public GameObject Avatar;


    // Start is called before the first frame update
    void Start()
    {
        visualEffect = this.GetComponent<VisualEffect>();
        DistanceBonesScript = Avatar.GetComponent<DistanceBones>();
    }

    // Update is called once per frame
    void Update()
    {
        SetPositionParameters();
        SetDistanceBonesParameters();
    }

    public void SetPositionParameters()
    {
        visualEffect.SetFloat(PositionX, (DistanceBonesScript._AvatarPositionX));
        visualEffect.SetFloat(PositionY, (DistanceBonesScript._AvatarPositionY));
        visualEffect.SetFloat(PositionZ, (DistanceBonesScript._AvatarPositionZ));
    }

    public void SetDistanceBonesParameters()
    {
        visualEffect.SetFloat(DistanceRightLeftHandX, (DistanceBonesScript._distanceBetweenLeftRightBonesX));
        visualEffect.SetFloat(DistanceRightLeftHandY, (DistanceBonesScript._distanceBetweenLeftRightBonesY));
        visualEffect.SetFloat(DistanceToeAndHeadBonesX, (DistanceBonesScript._distanceBetweenToeAndHeadBonesX));
        visualEffect.SetFloat(DistanceToeAndHeadBonesY, (DistanceBonesScript._distanceBetweenToeAndHeadBonesY));
    }
}