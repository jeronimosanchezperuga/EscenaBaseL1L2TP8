using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPad : MonoBehaviour
{
    string name;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        name = gameObject.name;

        if (name == "REINICIAR")
        {
            KeyPadPassword.passwordInput = "";
        }
        else
        {
            KeyPadPassword.passwordInput += name;
        }
        
    }

}
