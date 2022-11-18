using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    Rigidbody rgb;
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name=="dart(Clone)")
        {
            rgb=col.gameObject.GetComponent<Rigidbody>();
            rgb.isKinematic=true;
            float dis=Vector3.Distance(col.gameObject.transform.position,transform.position);
            if(dis<0.1f)
            {
                Debug.Log("1");
            }
            else if(dis<0.15f)
            {
                Debug.Log("2");
            }
            else if(dis<0.25f)
            {
                Debug.Log("3");
            }
            else if(dis<0.35f)
            {
                Debug.Log("4");
            }
            else if(dis<0.45f)
            {
                Debug.Log("5");
            }
            else
            {
                Debug.Log("6");
            }
        }
    }
}
