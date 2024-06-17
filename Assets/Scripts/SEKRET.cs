using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEKRET : MonoBehaviour
{
    public GameObject sekretPic;
    public float sekretTimer;    
    public int spaceCounter;    
    // Start is called before the first frame update
    void Start()
    {
        sekretTimer = 0;
        spaceCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        sekretTimer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spaceCounter += 1;
            if(sekretTimer >= 10)
            {
                if(spaceCounter >= 50)
                {
                    Instantiate(sekretPic, transform.position, Quaternion.identity);
                    spaceCounter = 0;
                    sekretTimer = 0;
                }
                else
                {
                    spaceCounter = 0;
                    sekretTimer = 0;
                }
            }            
        }                     
    }
}
