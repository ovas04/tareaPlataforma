using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour
{
    public GameObject obj;
    Transform tranObj;
    Transform tranCam;
    Rigidbody rbd;

    //**********************************************************

    Vector3 dirreccion = new Vector3();


    //**********************************************************

    int salto;
    public float fuerza = 0.2f;
    public float VelRota = 40f;
    public float VelMax = 40f;
    int i;


    //**********************************************************

    // Start is called before the first frame update
    void Start()
    {

        rbd = obj.GetComponent<Rigidbody>();
        tranObj = obj.GetComponent<Transform>();
        tranCam = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.UpArrow) && rbd.velocity.magnitude < VelMax)
        {
            dirreccion = new Vector3(tranObj.position.x - tranCam.position.x, 0f, tranObj.position.z - tranCam.position.z);
            rbd.AddForce((dirreccion * fuerza) / Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow) && rbd.velocity.magnitude < VelMax)
        {
            dirreccion = new Vector3(tranObj.position.x - tranCam.position.x, 0f, tranObj.position.z - tranCam.position.z);
            rbd.AddForce((dirreccion * -1 * fuerza) / Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            tranObj.Rotate(new Vector3(0, VelRota, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            tranObj.Rotate(new Vector3(0, -VelRota, 0) * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            rbd.velocity = new Vector3(0, rbd.velocity.y, 0);
        }

        
    }

}
