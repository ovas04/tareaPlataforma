using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//  
public class checkPoint : MonoBehaviour
{
    Vector3 checkpoint;
    Transform tranObj;
    public int points=0;
    
    Rigidbody rbd;
    // Start is called before the first frame update
    void Start()
    {
        tranObj = gameObject.GetComponent<Transform>();
        rbd = gameObject.GetComponent<Rigidbody>();
        checkpoint = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (tranObj.position.y < -10)
        {
            tranObj.position = checkpoint;
            rbd.velocity = new Vector3(0, 0, 0);
        }
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        

        if (collision.gameObject.CompareTag("checkPoint"))
        {

            checkpoint = collision.transform.position;

            checkpoint = collision.gameObject.GetComponent<Transform>().position;

            
        }

        if (collision.gameObject.CompareTag("platM"))
        {

            tranObj.parent = collision.gameObject.GetComponentInParent<Transform>();

            
        }


        if (collision.gameObject.CompareTag("death"))
        {
            tranObj.position = checkpoint;
            rbd.velocity = new Vector3(0, 0, 0);
            Destroy(collision.gameObject);
        }

    }


    private void OnCollisionExit(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("platM"))
        {
            tranObj.parent = null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("point"))
        {
            points++;
             Destroy(other.gameObject );
           
        }
     }
    


}

     



    