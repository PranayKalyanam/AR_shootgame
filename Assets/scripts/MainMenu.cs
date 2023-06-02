using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TMP_Text HighTxt;
   

    void Start ()
    {
        HighTxt.text = "HighScore : " + PlayerPrefs.GetInt("highscore",0).ToString();
    }
    public void PlayGame_easy()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   we can use this also
        SceneManager.LoadScene("ShootGame_easy");

    }
    public void PlayGame_medium()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   we can use this also
        SceneManager.LoadScene("ShootGame_medium");

    }
    public void PlayGame_hard()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   we can use this also
        SceneManager.LoadScene("ShootGame_hard");

    }

    public void ExitGame ()
    {
        Application.Quit();
    }

    public void GameInstructions()
    {

        SceneManager.LoadScene("instructions");
    }

    public void Gamelevel()
    {

        SceneManager.LoadScene("Levels");
    }



}