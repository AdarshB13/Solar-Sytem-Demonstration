using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    [SerializeField]
    GameObject ori;
    float othermass;
    float ownmass;
    Rigidbody rgb;

    void Start()
    {
        othermass=ori.GetComponent<Rigidbody>().mass;
        rgb=GetComponent<Rigidbody>();
        ownmass=rgb.mass;
    }

    void Update()
    {
        float distance=Vector3.Distance(ori.transform.position,transform.position);
        float force=6.674f*Mathf.Pow(10f,-11f)*othermass*ownmass/(distance*distance);
        Vector3 dir=Vector3.Normalize(ori.transform.position-transform.position);
        rgb.AddForce(force*dir);
    }
}
