using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public void QuitGame() //This function closes the application when triggered
    {
        Application.Quit();
    }

    public void PlayGame() //This function starts the game by loading the first "Level" scene
    {
        SceneManager.LoadScene("Leo scene");
    }
    public void BackToMenu() //This function starts the game by loading the first "Level" scene
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void EndGameMenu() //This function starts the game by loading the first "Level" scene
    {
        SceneManager.LoadScene("EndGameMenu");
    }

    public void GameOverMenu() //This function starts the game by loading the first "Level" scene
    {
        SceneManager.LoadScene("GameOverMenu");
    }
    public void DifficultyMenu() //This function loads the difficulty menu scene
    {
        SceneManager.LoadScene("DifficultyMenu");
    }
    public void CreditsMenu() //This function loads the difficulty menu scene
    {
        SceneManager.LoadScene("CreditsMenu");
    }
    public void Easy() //This function changes the difficulty
    {
        Globals.time = 50;
    }
    public void Normal() //This function changes the difficulty
    {
        Globals.time = 30;
    }

    public void Hard() //This function changes the difficulty
    {
        Globals.time = 15;
    }

}
