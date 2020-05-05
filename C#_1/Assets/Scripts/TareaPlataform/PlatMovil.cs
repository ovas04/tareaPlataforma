using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatMovil : MonoBehaviour
{
    public GameObject lim1, lim2;
    int i = 1;
    public float vel=3;

    private void Start()
    {
        
    }
    private void Update()
    {
        
    }
    private void FixedUpdate()
    {

        if (i == -1) transform.position = (Vector3.MoveTowards(transform.position, lim1.transform.position, vel * Time.fixedDeltaTime));


        if (i == 1) transform.position = (Vector3.MoveTowards(transform.position, lim2.transform.position, vel * Time.fixedDeltaTime));


        if (transform.position == lim2.transform.position)
        {
            i = -1;
        }
        else if (transform.position == lim1.transform.position) i = 1;
    }
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            collision.transform.parent = transform;
      

        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            collision.transform.parent = null;
        }
    }
}




    
    
    
    /*public GameObject lim1, lim2;
    Rigidbody rbd;
    Transform tran;
    Vector3 dirrecion;
    public float vel;
    // Start is called before the first frame update
    void Start()
    {
        dirrecion = new Vector3();
        dirrecion = lim1.transform.position - lim2.transform.position;
      //  rbd = gameObject.GetComponent<Rigidbody>();
   //     tran = gameObject.GetComponent<Transform>();
      //  transform.Translate(dirrecion *vel* Time.deltaTime);
    //    rbd.velocity = dirrecion * vel;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(dirrecion+gameObject.name);
    }

    private void FixedUpdate()
    {
        transform.Translate(dirrecion * vel * Time.fixedDeltaTime);
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("lim"))
        {

            Debug.Log("entre loco");
            // rbd.velocity = -1*dirrecion * vel;
            // transform.Translate(dirrecion*vel*Time.deltaTime);
            // transform.Translate(dirrecion);
            dirrecion = -1 * dirrecion;

        }

        if (other.CompareTag("lim2"))
        {
            //  rbd.velocity = dirrecion * vel;
            // transform.Translate(-1*dirrecion*vel*Time.deltaTime);
            //   transform.Translate(-1*dirrecion);
            dirrecion = -1*dirrecion;
        }

        
    }

}
*/