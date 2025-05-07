using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");

        if (player != null)
        {
            Collider2D playerCollider = player.GetComponent<Collider2D>();
            Collider2D projectileCollider = GetComponent<Collider2D>();

            if (playerCollider != null && projectileCollider != null)
            {
                Physics2D.IgnoreCollision(projectileCollider, playerCollider);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Box"))
        {
            GameManager.Instance.AddScore(1);
            Destroy(collision.gameObject);
        }

        Destroy(gameObject);
    }
}