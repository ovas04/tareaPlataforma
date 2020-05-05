using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio_4 : MonoBehaviour
{  
    // public GameObject[] granadas;
    // Rigidbody[] rbdG; //privado //privado
   // public GameObject[] objeto;
    // Start is called before the first frame update

    Rigidbody[] rbdB; //privado
    Rigidbody[] rbd;
    public GameObject[] balas;
   
    public float velocidad;
    
    void Start()
    {
        /*
        in_rbd_obj(rbdB,balas);
        vel_asg(rbdB);
        */
       //asg_vel(rbd);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) { 
            
            asg_vel(rbd);
            Debug.Log("velocidad");
        }
     }

     void FixedUpdate() //velocidad 
    {
        
    }

    void vel_asg(Rigidbody[] rbd)
    {
        for (int i = 0; i < rbd.Length; i++)
        {
            rbd[i].velocity = new Vector3(0,0, velocidad);
        }


    }
    void asg_vel(Rigidbody[] rbd)
    {
        for(int i=0; i<rbd.Length; i++)
        {
            rbd[i].velocity = new Vector3(0, 0, velocidad);
        }
    }



    void in_rbd_obj(Rigidbody[]  rbd, GameObject[] obj)
    {

        for (int i = 0; i < obj.Length; i++)
        {
            rbd[i] = obj[i].GetComponent<Rigidbody>();
        }

        /*
         * 
         * void in_rbd_obj(Rigidbody  rbd)
        for (int i = 0; i < objeto.Length; i++)
        {
            rbd[i] = objeto[i].GetComponent<Rigidbody>();
        }
        */
    }
}
