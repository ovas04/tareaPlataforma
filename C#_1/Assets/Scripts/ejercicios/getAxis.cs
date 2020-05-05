using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getAxis : MonoBehaviour
{
    Rigidbody rbd;
    public float x, z, fuerza;
    private void Start()
    {
        rbd = GetComponent<Rigidbody>();
    }

    private void Update()
    {


        

    }


    private void FixedUpdate()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        rbd.velocity = new Vector3(x*fuerza, rbd.velocity.y,rbd.velocity.z);
        rbd.velocity = new Vector3(rbd.velocity.x, rbd.velocity.y, z * fuerza);
    }
}
