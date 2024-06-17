using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstEnemiesSpawn : MonoBehaviour
{
    public GameObject Enemies;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Enemies, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
