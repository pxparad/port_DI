using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomBorder : MonoBehaviour
{
    private PointManager _pointManager;
    public GameObject Explosion;

    private void Start()
    {
        _pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")

        {
            Instantiate(Explosion, collision.gameObject.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            _pointManager.UpdateScore(-100);
        }
    }
}
