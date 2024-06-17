using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float MoveSpeed;
    public GameObject Explosion;
    private PointManager _pointManager;
    public GameObject HitSound;
    void Start()
    {
        _pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
        Destroy(gameObject, 4);
    }
    void Update()
    {
        transform.Translate(Vector2.up * MoveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Instantiate(Explosion, transform.position, Quaternion.identity);
            Instantiate(HitSound, transform.position, Quaternion.identity);          
            Destroy(collision.gameObject);
            _pointManager.UpdateScore(MAINPARAM.gamePoints);
            Destroy(gameObject);
        }
    }
}
