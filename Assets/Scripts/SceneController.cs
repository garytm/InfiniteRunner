using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("MainGame");
    }
    public void PlayEndless()
    {
        SceneManager.LoadScene("EndlessMode");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void HighScores()
    {
        SceneManager.LoadScene("HighScoreTable");
    }
}