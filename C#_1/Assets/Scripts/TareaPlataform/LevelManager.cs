using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    checkPoint check;
    public Text pointTxt;
    // Start is called before the first frame update
    void Start()
    {
        check = FindObjectOfType<checkPoint>();
    }

    // Update is called once per frame
    void Update()
    {
        pointTxt.text = ("Points : "+check.points);
    }
}
