using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canonTorreta : MonoBehaviour
{
    public GameObject player,BalaTorreta,canon;
    public float vel;
    public float lapso = 1f;
    public float rango;
    Vector3 direccion;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Disparo",0,lapso); 
    }

    // Update is called once per frame
    void Update()
    {

        direccion = (player.transform.position - transform.position);
        if (direccion.magnitude <= rango)
        {
            
            transform.forward = direccion.normalized;
        }
        
        
    }

    void Disparo()
    {
        if (direccion.magnitude <= rango)
        {
            GameObject Bala = Instantiate(BalaTorreta, canon.transform.position, Quaternion.identity);

            Bala.transform.up = direccion.normalized;
            Bala.GetComponent<Rigidbody>().velocity = direccion.normalized * vel;

            Destroy(Bala, 3.5f);
        }
        
    }
}
