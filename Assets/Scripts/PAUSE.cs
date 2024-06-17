using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAUSE : MonoBehaviour
{
    public GameObject pauseWindow;
    bool isPaused;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused == false)
            {
                Time.timeScale = 0;
                pauseWindow.SetActive(true);
                isPaused = true;
            }

            else if (isPaused == true)
            {
                Time.timeScale = 1;
                pauseWindow.SetActive(false);
                isPaused = false;
            }
        }
    }

    public void continueButton()
    {
        Time.timeScale = 1;
        pauseWindow.SetActive(false);
        isPaused = false;
    }


}

