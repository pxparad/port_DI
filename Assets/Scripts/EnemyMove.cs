using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float MoveSpeed;
    public float MoveDownSpeed;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * MoveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Border")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - MoveDownSpeed, transform.position.z);
            MoveSpeed *= -1;
        }
    }

   /* private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Border")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - MoveDownSpeed, transform.position.z);
            MoveSpeed *= -1;
        }
    }*/
}
