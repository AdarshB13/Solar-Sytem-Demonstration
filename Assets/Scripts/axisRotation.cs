using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class axisRotation : MonoBehaviour
{
    [SerializeField]
    Transform origin;
    [SerializeField]
    Vector3 axis=new Vector3(0,1,0);
    [SerializeField]
    float anglerotate=1;
    void Update()
    {
        transform.RotateAround(origin.position,axis,(1/anglerotate)*Time.deltaTime);
    }
}
