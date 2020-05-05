using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class prueba1 : MonoBehaviour
{
    Rigidbody rbd;
    Transform tran;
    GameObject objeto;
    Vector3 vector3;

    // Start is called before the first frame update
    void Start()
    {
       vector3 = new Vector3(0,250,250);
       rbd = gameObject.GetComponent<Rigidbody>();
      
      
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rbd.AddForce(vector3);
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            rbd.AddForce(new Vector3(0,0,-50));
        }
    }

    private void FixedUpdate()
    {
        
    }


}
