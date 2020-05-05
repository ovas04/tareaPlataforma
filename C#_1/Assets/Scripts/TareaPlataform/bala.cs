using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    Rigidbody rbd;
    Transform tran;
    GameObject objeto;
    public Vector3 vel;

    // Start is called before the first frame update
    

    void Start()
    {
        tran = gameObject.GetComponent<Transform>();
       // vector3 = new Vector3(0, 5, 0);
       // tran.position = vector3;
        rbd = gameObject.GetComponent<Rigidbody>();
        rbd.velocity = vel;


    }
        

        // Update is called once per frame
        void Update()
    {
        //Debug.Log(tran.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("cont"))
        {
            Destroy(gameObject);
        }
    }


}
