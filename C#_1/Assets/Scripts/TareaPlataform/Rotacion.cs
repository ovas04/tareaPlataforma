using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    public char tipo;
    public float vel;
    Transform tran;
    // Start is called before the first frame update
    void Start()
    {
        tran = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(tipo == 'x')
        {
            tran.Rotate(vel, 0, 0);
        }
        if(tipo == 'y')
        {
            tran.Rotate(0, vel, 0);
        }
        if(tipo == 'z')
        {
            tran.Rotate(0, 0, vel);
        }

    }
}
