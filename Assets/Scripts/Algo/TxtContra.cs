using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TxtContra : MonoBehaviour
{
    string contra;

    // Start is called before the first frame update
    void Start()
    {
        contra = KeyPadPassword.password;
        GetComponent<TextMeshPro>().text = "CONTRA : 123 " + contra;
        //No se porque pero ignora la variable "contra" cuando la intento poner en el texto del TextMeshPro
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
