using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierMove : MonoBehaviour
{
    private float _moveDownSpeed = 0.7f;    
    private void Start()
    {
        Destroy(gameObject, 20);
    }
    void Update()
    {
        transform.Translate(Vector2.down * _moveDownSpeed * Time.deltaTime);
    }   
}
