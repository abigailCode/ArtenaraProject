using OVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject CreditsPanel;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void StartGame()
    {
        GameManager.instance.ResetState();
        SceneController.instance.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    //CREDITS
    public void ShowCredits()
    {
        CreditsPanel.SetActive(true);
    }

    public void HideCredits()
    {
        CreditsPanel.SetActive(false);
    }

    public void GoToMenu()
    {
        SceneController.instance.LoadScene("Menu");
    }
}
