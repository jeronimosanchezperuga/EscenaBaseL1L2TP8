using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogeManager : MonoBehaviour
{
    [SerializeField] GameObject dialogueUI;
    [SerializeField] TextMeshProUGUI textoDelDialogo;
    [SerializeField] string[] frasesDialogo;
    [SerializeField] int posicionFrase;
    [SerializeField] bool hasTalked;
    public GameObject pressE, canvasWinner;

    // Start is called before the first frame update
    void Start()
    {
        dialogueUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && hasTalked == false)
        {
            NextFrase();
        }   
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            frasesDialogo = other.gameObject.GetComponent<NPCBehavior>().Data.dialogueFrases;
            dialogueUI.SetActive(true);

            if (!hasTalked)
            {
                //al entrar activa la UI de dialogo
                textoDelDialogo.text = "Hola, soy Jero y estoy encerrado, necesito que me ayudes a salir de aquí";
            }

            else if (hasTalked && !KeyPadPassword.hasEscaped)
            {
                pressE.SetActive(false);
                textoDelDialogo.text = "Ya hable con vos, anda a buscar";
            }

            else if (hasTalked && KeyPadPassword.hasEscaped)
            {
                pressE.SetActive(false);
                textoDelDialogo.text = "Gracias por ayudarme a escapar, ahora puedo volver a mi casa";
                StartCoroutine(waitForCooldown());

            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
           //al entrar desactiva la UI de dialogo
            dialogueUI.SetActive(false);
        }
    }

    void NextFrase()
    {
        if (posicionFrase < frasesDialogo.Length)
        {
            textoDelDialogo.text = frasesDialogo[posicionFrase];
            posicionFrase++;
        }

        else
        {
            dialogueUI.SetActive(false);
            hasTalked = true;
        }
        
    }

    IEnumerator waitForCooldown() //Cooldown para esperar un segundo al sacarme vida
    {
        yield return new WaitForSeconds(3);
        canvasWinner.SetActive(true);
        yield return new WaitForSeconds(3);
    }
}
