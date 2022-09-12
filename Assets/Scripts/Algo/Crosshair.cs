using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crosshair : MonoBehaviour
{
    public Image mira;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mira.color = Color.grey;
            Debug.Log("Click");
            mira.transform.localScale = new Vector3(1.25f, 1.25f, 1.25f);
        }

        if (Input.GetMouseButtonUp(0))
        {
            mira.color = Color.white;
            Debug.Log("Saco Click");
            mira.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        }
    }
}
