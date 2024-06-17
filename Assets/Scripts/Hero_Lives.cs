using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hero_Lives : MonoBehaviour
{
    private int Lives = MAINPARAM.HeroLives;
    public GameObject Explosion;
    public Image[] LivesImg;
    private PointManager _pointManager;
    public GameObject DeathWindow;
    public GameObject DamageSound;

    void Start()
    {        
        _pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
    }
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < LivesImg.Length; i++)
        {
            if(i < Lives)
            {
                LivesImg[i].enabled = true;
            }

            else if(i >= MAINPARAM.HeroLives)
            {
                LivesImg[i].enabled = false;                
            }
            else
            {
                LivesImg[i].enabled = false;
            }
        }

        if (Lives >= 6)
        {
            Lives -= 1;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Instantiate(Explosion, transform.position, Quaternion.identity);
            Instantiate(DamageSound, transform.position, Quaternion.identity);            
            Lives -= 1;

            if (Lives <= 0)
            {
                LivesImg[0].enabled = false;
                Destroy(gameObject);
                Time.timeScale = 0;
                DeathWindow.SetActive(true);
            }
        }

        else if (collision.gameObject.tag == "Barrier")
        {
            Destroy(collision.gameObject);
            Instantiate(Explosion, transform.position, Quaternion.identity);
            Instantiate(DamageSound, transform.position, Quaternion.identity);          
            Lives -= 1;

            if (Lives <= 0)
            {
                LivesImg[0].enabled = false;
                Destroy(gameObject);
                Time.timeScale = 0;
                DeathWindow.SetActive(true);
            }
        }

        else if (collision.gameObject.tag == "HPplus")
        {
            Destroy(collision.gameObject);
            Lives += 1;
            if(Lives >= 5)
            {
                _pointManager.UpdateScore(100);
            }           
        }

        else if (collision.gameObject.tag == "Bomb")
        {            
            Instantiate(Explosion, transform.position, Quaternion.identity);
            Instantiate(DamageSound, transform.position, Quaternion.identity);           
            Lives -= 1;

            if (Lives <= 0)
            {
                LivesImg[0].enabled = false;
                Destroy(gameObject);
                Time.timeScale = 0;
                DeathWindow.SetActive(true);
            }
        }
    }

}
