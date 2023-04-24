using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Button : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject namePanel;
    public TextMeshProUGUI user;
    public string player = "";

    public void Start()
    {
        startPanel.SetActive(true);
        namePanel.SetActive(false);

    }

    public void CambiarPanel00()
    {
        startPanel.SetActive(false);
        namePanel.SetActive(true);
    }
    public void CambiarPanel01()
    {
        player = user.text;
        namePanel.SetActive(false);
        SceneManager.LoadScene(1);
    }
    
}