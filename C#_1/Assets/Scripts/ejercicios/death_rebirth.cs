using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death_rebirth : MonoBehaviour
{

    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            //player.transform.position = new Vector3();
            SceneManager.LoadScene("SampleScene");
            
        }
    }
}
