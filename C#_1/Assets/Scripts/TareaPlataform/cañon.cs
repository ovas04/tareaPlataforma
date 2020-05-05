using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cañon : MonoBehaviour
{
    
    public GameObject bala;
    Rigidbody rbd;
    // Start is called before the first frame update
    void Start()
    {
        // rbdB.velocity = new Vector3(-5, 0, 0);

        InvokeRepeating("Lanzar", 2.0f, 2.0f);

    }
    // Update is called once per frame
    // Update is called once per frame
    void Update()
    {

       // StartCoroutine(ExampleCoroutine()); 
      

    }
    /*
    void asg_vel(Rigidbody[] rbd)
    {
        for (int i = 0; i < rbd.Length; i++)
        {
            rbdB.velocity = new Vector3(5, 0, 0);
        }
    }
    
    */
    /*
    public IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(2);
        GameObject temp = Instantiate(bala);
        temp.transform.position = new Vector3(23.25f, 1.04f, 32.8f);
        rbd = temp.GetComponent<Rigidbody>();
        rbd.velocity = new Vector3(-5, 0, 0);
        
    }*/
    void Lanzar()
    {
        Instantiate(bala, transform.position, transform.rotation);
    }

  

}
