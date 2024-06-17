using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPplusMover : MonoBehaviour
{
    public float MoveDownSpeed = 0.9f;


    private void Start()
    {
        Destroy(gameObject, 15);
    }
    void Update()
    {
        transform.Translate(Vector2.down * MoveDownSpeed * Time.deltaTime);
    }
}
