using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    public GameObject Boss;
    public GameObject text;
    public GameObject camara;
    public float vel;
    Rigidbody rbd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject obj = Instantiate(Boss, Boss.gameObject.transform.position, Quaternion.identity);
            Instantiate(text, text.gameObject.transform.position, Quaternion.identity);
            rbd = obj.GetComponent<Rigidbody>();
            rbd.velocity = new Vector3(0, 0, vel);
            camara.gameObject.GetComponent<Transform>().Rotate(0, 180, 0);
        }
    }
}
