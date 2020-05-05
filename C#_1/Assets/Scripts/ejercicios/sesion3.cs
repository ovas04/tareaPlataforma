using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sesion3 : MonoBehaviour
{
    public GameObject cubo;
    public bool stay_ground;
    Rigidbody rbd;
    Vector3 gravity = new Vector3(0, -9.81f, 0);
    public float velocidad, fuerza, fuerzaJ, escala_gravedad;
    public int points,saltos;
    float x, z, X, Z;
    int i;
    float time1,time2;

    public float tiempo_pw;

    public GameObject cubo1, cubo2;


    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody>();
        Physics.gravity = gravity * escala_gravedad;
       
        

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
            if (i <= saltos)
            {
                rbd.AddForce(new Vector3(0, 1, 0) * fuerzaJ, ForceMode.Impulse);
                
            }

        }

        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        rbd.velocity = new Vector3(x * velocidad, rbd.velocity.y, z * velocidad);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("sesion 3");
        }

        



    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("point"))
        {
 
            Time.timeScale = 0.2f;
            time1 = Time.time;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("point"))
        {

            Time.timeScale = 1f;

        }
    }


}
