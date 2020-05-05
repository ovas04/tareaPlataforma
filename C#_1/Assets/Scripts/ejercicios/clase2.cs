using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clase2 : MonoBehaviour
{
    Rigidbody rbd;
    public float fuerza;
    public float vel;
    int contr;

    // Start is called before the first frame update
    void Start()
    {
        rbd = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetKey(KeyCode.Space) && rbd.velocity.magnitude==0)
        {
            rbd.AddForce(new Vector3(0, 1, 0)*fuerza/Time.fixedDeltaTime);
        }*/
        if (Input.GetKey(KeyCode.UpArrow) && rbd.velocity.magnitude==0)
        {
            rbd.velocity= new Vector3(0,0,1)*vel;
         }
        if (Input.GetKey(KeyCode.DownArrow) && rbd.velocity.magnitude==0)
        {
            rbd.velocity= new Vector3(0,0,-1)*vel;
         }

        if (Input.GetKey(KeyCode.Space) && contr < 2)
        {
            rbd.AddForce(new Vector3(0, 1, 0)*fuerza/Time.fixedDeltaTime);
            contr++;
        }
        else if( contr >= 2 && rbd.position.y <= 3)
        {
            contr = 0;
        }
        Debug.Log(contr);
    }
}
