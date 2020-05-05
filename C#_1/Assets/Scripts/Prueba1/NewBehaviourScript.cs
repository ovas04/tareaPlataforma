using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    GameObject bala;
    public float velocidad;
    Vector3 vel;
    // Start is called before the first frame update
    void Start()
    {
        vel = new Vector3(velocidad, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(retraso());
      

    }

    IEnumerator retraso()
    {
        yield return new WaitForSeconds(2);
        GameObject _bala = Instantiate(bala); // AL obejto que tiene el script
        _bala.GetComponent<Transform>().position = new Vector3(23.25f, 1.04f, 32.8f);
        _bala.GetComponent<Rigidbody>().velocity = vel;
    }


}
