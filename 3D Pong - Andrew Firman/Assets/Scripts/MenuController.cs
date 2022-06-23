using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        //Debug.Log("Created by andrew - firman - saputra - 149251970101 - 61");

    }
    public void OpenCredit()
    {
        //Debug.Log("Created by Andrew Firman");
        SceneManager.LoadScene("Credit");
    }
    public void ToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
        //Debug.Log("Created by andrew - firman - saputra - 149251970101 - 61");
    }
    public void ToHowTo()
    {
        SceneManager.LoadScene("HowTo");
        //Debug.Log("Created by andrew - firman - saputra - 149251970101 - 61");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}