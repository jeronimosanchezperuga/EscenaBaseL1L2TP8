using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPadPassword : MonoBehaviour
{
    public static string passwordInput, password;
    public string ingresaContra;
    public GameObject puerta, puertaAbierta;
    public static bool hasEscaped;
    

    // Start is called before the first frame update
    void Start()
    {
        password = ingresaContra;
    }

    // Update is called once per frame
    void Update()
    {
        if (passwordInput == password)
        {
            Debug.Log("Escapaste");
            Destroy(puerta);
            puertaAbierta.SetActive(true);
            hasEscaped = true;
            
        }
    }
}
