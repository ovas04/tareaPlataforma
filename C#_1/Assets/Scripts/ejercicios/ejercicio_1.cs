using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio_1 : MonoBehaviour
{
    int entero;
    string s;
    int[] i;
    char caracter;
    float f;
    double d;
    long l;
    decimal decima;
   
    List<int> L;
    // structs
    Ray ray;
    Vector2 vector2 = new Vector2(2, 5);
    Vector3 vector3 = new Vector3();

    //clases
    Transform tran;
    Rigidbody rgb;
    GameObject cubo_hijo;




    // Start is called before the first frame update
    void Start()
    {
        f = 2f;
        caracter = 'a';

        tran = gameObject.GetComponent < Transform >();
      //  tran = gameObject.GetComponent < Rigidbody >(); esta mal xq gameObejcet es solo transform
      //  gameObject.GetComponent<Transform>().position = new Vector3(1, 1, 1);


        tran.position = vector3;


    

        vector2 = new Vector2(2, 1);
        vector3 = new Vector3(1,1,1);
        ray = new Ray(vector3, new Vector3(1, 1, 1));//(origen,direccion)
        ray = new Ray(vector3, vector2);//(origen,direccion)


        tran.position = vector3;

        Debug.Log(ray);
        /*
        Debug.Log(vector3);
        Debug.Log("el valor es "+vector3);
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
