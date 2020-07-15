using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsActions : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionMenu;


    public void ChangeScene(string scene)
    {
        SceneManager.LoadSceneAsync(scene);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Options()
    {
        mainMenu.SetActive(false);
        optionMenu.SetActive(true);
    }

    public void MainMenu()
    {
        optionMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
