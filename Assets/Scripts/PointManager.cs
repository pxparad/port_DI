using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointManager : MonoBehaviour
{
    public int Score;
    public TMP_Text scoreText;
    public GameObject DeathWindow;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "" + 0 + Score;
    }

    public void UpdateScore(int points)
    {
        Score += points;
        scoreText.text = "" + Score;
    }

    private void Update()
    {
        if(Score <= -100)
        {
            Time.timeScale = 0;
            DeathWindow.SetActive(true);
        }        
    }
}

    
