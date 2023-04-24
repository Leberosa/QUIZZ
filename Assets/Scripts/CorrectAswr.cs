using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CorrectAswr : MonoBehaviour
{
    public GameObject button;
    public ButtonActionFacil pregunta;
    public TextMeshProUGUI buttonText;
    public TextMeshProUGUI scoreText;
    string[] respuestas = new string[10];
    string respuestaF = "";
    string respuestaCorrecta1 = "56";
    string respuestaCorrecta2 = "24";
    string respuestaCorrecta3 = "72";
    string respuestaCorrecta4 = "27";
    string respuestaCorrecta5 = "42";
    string respuestaCorrecta6 = "28";
    string respuestaCorrecta7 = "64";
    string respuestaCorrecta8 = "54";
    string respuestaCorrecta9 = "48";
    string respuestaCorrecta10 = "63";
    public int npregunta = 0;
    public int score = 0;

    private void Start()
    {
        respuestas[0] = respuestaCorrecta1;
        respuestas[1] = respuestaCorrecta2;
        respuestas[2] = respuestaCorrecta3;
        respuestas[3] = respuestaCorrecta4;
        respuestas[4] = respuestaCorrecta5;
        respuestas[5] = respuestaCorrecta6;
        respuestas[6] = respuestaCorrecta7;
        respuestas[7] = respuestaCorrecta8;
        respuestas[8] = respuestaCorrecta9;
        respuestas[9] = respuestaCorrecta10;
        score = 0;
        
    }
    public void RespuestaCorrecta()
    {
        npregunta = pregunta.numeroPregunta;
        respuestaF = respuestas[npregunta];
        
        if (buttonText.text == respuestaF)
        {
            button.GetComponent<Image>().color = Color.green;
            score += 100;
            scoreText.text = score.ToString();
            pregunta.objetosPanels[npregunta].SetActive(false);
            pregunta.PreguntaRandom();
    
        }
        else if (buttonText.text != respuestaF)
        {
            button.GetComponent<Image>().color = Color.red;
            pregunta.objetosPanels[npregunta].SetActive(false);
            pregunta.PreguntaRandom();
        }
    }
}
