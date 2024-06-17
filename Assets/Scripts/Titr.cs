using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Titr : MonoBehaviour
{
    public GameObject ReadMe;
    public GameObject Story; 
        
    bool titr1 = true;
    bool titr2;    
    void Update()
    {        
        if (Input.GetKeyDown(KeyCode.Space))
        {            
            if(titr1 == true)
            {
                ReadMe.SetActive(false);
                Story.SetActive(true);
                titr1 = false;
                titr2 = true;
            }

            else if(titr2 == true)
            {
                Story.SetActive(false);
                SceneManager.LoadScene("ChooseDifficult");
            }
        }

        else if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (titr1 == true)
            {
                ReadMe.SetActive(false);
                Story.SetActive(true);
                titr1 = false;
                titr2 = true;
            }

            else if (titr2 == true)
            {
                Story.SetActive(false);
                SceneManager.LoadScene("ChooseDifficult");
            }
        }
    }
}
