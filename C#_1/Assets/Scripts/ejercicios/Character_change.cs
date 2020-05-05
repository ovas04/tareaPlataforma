using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_change : MonoBehaviour
{
    public Mesh char2;
    MeshFilter character_actual;
    // Start is called before the first frame update
    void Start()
    {
        character_actual = GetComponent<MeshFilter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            character_actual.mesh = char2;
            Debug.Log("new character");
        }
    }
}
