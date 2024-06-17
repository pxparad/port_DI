using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUN_Enemy : MonoBehaviour
{
    public GameObject Bomb;
    private float _shootingTimer;
    private float _shootTimeMax = MAINPARAM.shootTimeMax;
    private float _shootTimeMin = MAINPARAM.shootTimeMin;

    private void Start()
    {
        _shootingTimer = Random.Range(_shootTimeMin, _shootTimeMax);
    }

    private void Update()
    {
        _shootingTimer -= Time.deltaTime;
        if(_shootingTimer <= 0)
        {
            Instantiate(Bomb, transform.position, Quaternion.identity);
            _shootingTimer = Random.Range(_shootTimeMin, _shootTimeMax);
        }
    }

}
