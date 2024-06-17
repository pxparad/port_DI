using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPspawner : MonoBehaviour
{
    public GameObject HPbox;
    private float _HPTimer;
    private float _HPTimeMax = 25;
    private float _HPTimeMin = 10;
    private float _HPtime;

    private void Start()
    {
        _HPTimer = Random.Range(_HPTimeMin, _HPTimeMax);
    }

    private void Update()
    {
        _HPTimer -= Time.deltaTime;
        if (_HPTimer <= 0)
        {
            _HPtime = Random.Range(1, 9);
            if (_HPtime >= 8)
            {
                Instantiate(HPbox, transform.position, Quaternion.identity);
                _HPTimer = Random.Range(_HPTimeMin, _HPTimeMax);
            }
        }
    }
}

