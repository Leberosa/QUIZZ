using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro;

public class ButtonActionFacil : MonoBehaviour
{
    public int numeroPregunta = 0;
    public GameObject[] objetosPanels;
    public GameObject pregunta1;
    public GameObject pregunta2;
    public GameObject pregunta3;
    public GameObject pregunta4;
    public GameObject pregunta5;
    public GameObject pregunta6;
    public GameObject pregunta7;
    public GameObject pregunta8;
    public GameObject pregunta9;
    public GameObject pregunta10;
    public GameObject questionsPanel;
    public GameObject ScorePanel;
    public TextMeshProUGUI finalName;
    public TextMeshProUGUI finalScore;
    public CorrectAswr misCorrect;
    public Button misButton;
    int contadorPregunta;
    string fname = "";
    string fscore = "";

    // Start is called before the first frame update
    private void Start()
    {
        ScorePanel.SetActive(false);
        questionsPanel.SetActive(true);
        objetosPanels = new GameObject[10]; //Cantidad de preguntas
        numeroPregunta = 0;
        contadorPregunta = 0;

        //Asignar panel al array
        objetosPanels[0] = pregunta1;
        objetosPanels[1] = pregunta2;
        objetosPanels[2] = pregunta3;
        objetosPanels[3] = pregunta4;
        objetosPanels[4] = pregunta5;
        objetosPanels[5] = pregunta6;
        objetosPanels[6] = pregunta7;
        objetosPanels[7] = pregunta8;
        objetosPanels[8] = pregunta9;
        objetosPanels[9] = pregunta10;

        for (int i = 0; i < objetosPanels.Length; i++)
        {
            objetosPanels[i].SetActive(false);
        }
        PreguntaRandom();
    }

    public void PreguntaRandom()
    {
        if (contadorPregunta < 10)
        {
            contadorPregunta += 1;
            int indiceAleatorio = Random.Range(0, objetosPanels.Length);//Se genera un numero Random
            GameObject objetoAleatorio = objetosPanels[indiceAleatorio];
            objetoAleatorio.SetActive(true);
            numeroPregunta = indiceAleatorio;
        }
        else
        {
            FinalPanel();
        }
    }

    public void FinalPanel()
    {
        fname = misButton.player;
        fscore = misCorrect.score.ToString();
        questionsPanel.SetActive(false);
        finalName.text = fname;
        finalScore.text = fscore;
        ScorePanel.SetActive(true);
    }
}
