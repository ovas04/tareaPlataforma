using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public GameObject movil;
    Transform tran;
    Vector3 posR;
    // Start is called before the first frame update
    void Start()
    {
        tran = gameObject.GetComponent<Transform>();

        posR = transform.position - movil.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = movil.transform.position + posR;

    }
}
