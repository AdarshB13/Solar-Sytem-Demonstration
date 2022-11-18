using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot  : MonoBehaviour
{
    [SerializeField]
    GameObject ball;
    GameObject instance;
    Rigidbody rgb;
    [SerializeField]
    Transform cam;
    [SerializeField]
    int force;
    Renderer ren;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousepos=Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,1f));
            instance=Instantiate(ball,mousepos,Quaternion.identity);
            rgb=instance.GetComponent<Rigidbody>();
            Vector3 dir=mousepos-cam.position;
            dir=dir.normalized;
            rgb.AddForce(dir*force);
            ren=instance.GetComponent<Renderer>();
            Color rcolor=new Color(Random.value,Random.value,Random.value,1f);
            ren.material.SetColor("_Color",rcolor);
        }
    }
}
