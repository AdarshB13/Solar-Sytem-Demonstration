using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    Vector3 dir=new Vector3(0,-1,0);
    [SerializeField]
    float RotationSpeed=1;

    void Update()
    {
        transform.Rotate(dir*RotationSpeed*Time.deltaTime);
    }
}
