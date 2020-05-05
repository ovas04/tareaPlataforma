using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltoTarea : MonoBehaviour
{
    Rigidbody rbd;
    public float fuerzaSalto = 5f;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        rbd = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (rbd.velocity.y == 0)
            {
                i = 0;

            }

            i++;

            if (i <= 2)
            {
                rbd.AddForce(new Vector3(0, 1, 0) * fuerzaSalto / Time.fixedDeltaTime);

            }

        }


    }
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (!(collision.gameObject.CompareTag("Nojump") && collision.gameObject.CompareTag("point")) )
        {
            i = 0;
        }
    }


}
