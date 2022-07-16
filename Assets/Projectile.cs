using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Vector3 shootDir;
    private float moveSpeed = 50f;

    private void Start()
    {
        shootDir = Input.mousePosition - transform.position;
    }
    private void Update()
    {
        transform.position += shootDir.normalized * moveSpeed * Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag != "Player")
        {
            Destroy(gameObject);
        }
    }
}
