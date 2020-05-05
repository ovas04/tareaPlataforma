using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio_2 : MonoBehaviour
{
    float fuerza;
    /*public*/ float velocidad;
    Vector3 Vel;
    Transform tran;
    Rigidbody rbd;



    

    // Start is called before the first frame update
    void Start()
    {
        Vector3 direccion = new Vector3(0, 0, 1);

        Vel = direccion.normalized * velocidad;

       
        tran = gameObject.GetComponent<Transform>();
        rbd = gameObject.GetComponent<Rigidbody>();


       rbd.velocity = Vel;
       rbd.AddForce(new Vector3(0, 0, fuerza));



    }

    // Update is called once per frame
    void Update() // para logicas
    {
                Debug.Log(rbd.velocity);

    }

    void FixedUpdate()// para fisicas
    {
        rbd.AddForce(new Vector3(0, 0, fuerza));
    }
}
