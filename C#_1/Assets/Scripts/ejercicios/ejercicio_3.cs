using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio_3 : MonoBehaviour
{
    public float velocity;
    GameObject objeto;
    GameObject objeto0;
    GameObject objeto1;
    GameObject objeto2;

    Rigidbody obj_rbd; // permite fisicas mas no trasladarlo o teletransportarlo

    void Start()
    {
        // objeto = gameObject.GetComponent<GameObject>();
        obj_rbd = objeto.GetComponent<Rigidbody>();
        obj_rbd.velocity = new Vector3(0, 0, velocity);
        
        asg_vel(objeto1);
        asg_vel(objeto2);
        asg_vel(objeto0);



        void asg_vel(GameObject obj)
        {
            obj.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, velocity);
        }

    }
}
