using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMove : MonoBehaviour
{
    public float MoveSpeed;
    private float DirectionInput;
    
    // Update is called once per frame
    void Update()
    {
        DirectionInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * DirectionInput * MoveSpeed * Time.deltaTime);
    }
}
