using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{    
    public void StartGame()
    {
        SceneManager.LoadScene("Titr");
    }

    public void Easy()
    {
        MAINPARAM.HeroLives = 4;
        MAINPARAM.shootTimeMax = 8;
        MAINPARAM.shootTimeMin = 1;
        MAINPARAM._timeToShoot = 0.7f;
        MAINPARAM.gamePoints = 15;
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");        
    }

    public void Difficult()
    {
        MAINPARAM.HeroLives = 1;
        MAINPARAM.shootTimeMax = 5;
        MAINPARAM.shootTimeMin = 1;
        MAINPARAM._timeToShoot = 0.7f;
        MAINPARAM.gamePoints = 25;
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");        
    }

    public void ChooseDifficult()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("ChooseDifficult");        
    }
    
    public void newGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start");
    }
}
