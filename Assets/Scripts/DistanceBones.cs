using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//using Vector3 = System.Numerics.Vector3;

public class DistanceBones : MonoBehaviour
{
    private Animator anim;

    private Transform RightHandTransform;
    private Transform LeftHandTransform;
    private Transform HeadTransform;
    
    
    private Transform RightFootTransform;
    private Transform LeftFootTransform;

    public Vector3 _GlobalPosition;

    public float _AvatarPositionX;
    public float _AvatarPositionY;
    public float _AvatarPositionZ;

    // Values Left Right 
    public float _distanceBetweenLeftRightBonesX;
    public float _distanceBetweenLeftRightBonesY;

    // Values Toe And Head
    public float _distanceBetweenToeAndHeadBonesX;
    public float _distanceBetweenToeAndHeadBonesY;
    
    // Values Toe to Toe
    public float _distanceBetweenLeftFootAndRightFootX;
    public float _distanceBetweenLeftFootAndRightFootY;

    // Start is called before the first frame update
    void Start()
    {
        if (anim == null)
            anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckBones();
        _distanceBetweenLeftRightBonesX = CheckDistanceBonesX(RightHandTransform, LeftHandTransform);
        _distanceBetweenLeftRightBonesY = CheckDistanceBonesY(RightHandTransform, LeftHandTransform);
        _distanceBetweenToeAndHeadBonesX = CheckDistanceBonesX(HeadTransform, RightFootTransform);
        _distanceBetweenToeAndHeadBonesY = CheckDistanceBonesY(HeadTransform, RightFootTransform);
        _distanceBetweenLeftFootAndRightFootX = CheckDistanceBonesX(LeftFootTransform, RightFootTransform);
        _distanceBetweenLeftFootAndRightFootY = CheckDistanceBonesY(LeftFootTransform, RightFootTransform);
        
        
        //CheckDistanceBones(_distanceBetweenToeAndHeadBonesX, _distanceBetweenToeAndHeadBonesY, HeadTransform,
        //  RightToeTransform);

        GetGlobalPosition();
    }

    void GetGlobalPosition()
    {
        _GlobalPosition = gameObject.transform.position;

        _AvatarPositionX = _GlobalPosition.x;
        _AvatarPositionY = _GlobalPosition.y;
        _AvatarPositionZ = _GlobalPosition.z;
    }

    float CheckDistanceBonesX(Transform transformA, Transform transformB)
    {
        float distanceResult;
        distanceResult = Mathf.Abs(transformA.position.x - transformB.position.x);
        return distanceResult;
    }

    float CheckDistanceBonesY(Transform transformA, Transform transformB)
    {
        float distanceResult;
        distanceResult = Mathf.Abs(transformA.position.y - transformB.position.y);
        return distanceResult;
    }


    void CheckBones()
    {
        RightHandTransform = anim.GetBoneTransform(HumanBodyBones.RightHand);
        LeftHandTransform = anim.GetBoneTransform(HumanBodyBones.LeftHand);
        HeadTransform = anim.GetBoneTransform(HumanBodyBones.Head);
        RightFootTransform = anim.GetBoneTransform(HumanBodyBones.RightFoot);
        LeftFootTransform = anim.GetBoneTransform(HumanBodyBones.LeftFoot);
        
    }
}