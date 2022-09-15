using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float startTime;
    float timeLeft;
    public Image timer;
    public GameObject canvasLoser, clock;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = startTime;
    }

    // Update is called once per frame
    void Update()
    {   
        timeLeft -= Time.deltaTime;        
        timer.fillAmount = timeLeft / startTime;

        if (KeyPadPassword.hasEscaped)
        {
            clock.SetActive(false);
        }

        if (timeLeft < 6 && timeLeft > 5)
        {
            timer.color = Color.yellow;
        }

        else if (timeLeft < 5 && timeLeft > 4)
        {
            timer.color = Color.red;
        }

        else if (timeLeft < 4 && timeLeft > 3)
        {
            timer.color = Color.yellow;
        }

        else if (timeLeft < 3 && timeLeft > 2)
        {
            timer.color = Color.red;
        }

        else if (timeLeft < 2 && timeLeft > 1)
        {
            timer.color = Color.yellow;
        }

        else if (timeLeft < 1 && timeLeft > 0)
        {
            timer.color = Color.red;
        }
                
        else if (timer.fillAmount == 0 && !KeyPadPassword.hasEscaped) //Cuando se le acaba el tiempo
        {
            timeLeft = 0;
            canvasLoser.SetActive(true);
            //logica
        }
    }
}
