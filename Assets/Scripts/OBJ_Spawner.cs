using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBJ_Spawner : MonoBehaviour
{
    public GameObject[] objToSpawn;
    private float _timer;
    public float timeToSpawn;

    private void Start()
    {        
        _timer = timeToSpawn;        
    }

    private void Update()
    {
        _timer -= Time.deltaTime;
        if (_timer <= 0)
        {
            var objectIndex = Random.Range(0, objToSpawn.Length);
            Instantiate(objToSpawn[objectIndex], transform.position, Quaternion.identity);
            _timer = timeToSpawn;
        }
    }



    // Start is called before the first frame update
    /*void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while(true)
        {
            var objectIndex = Random.Range(0, objToSpawn.Length);

            Instantiate(objToSpawn[objectIndex], transform.position, Quaternion.identity);

            yield return new WaitForSeconds(timeToSpawn);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
