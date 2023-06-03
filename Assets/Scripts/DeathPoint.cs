using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPoint : MonoBehaviour
{

    private Rigidbody2D playerRb;
    private Vector3 StartPosition;
    private bool isDead = false;

    void Start()
    {
        playerRb = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        StartPosition = playerRb.transform.position;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && !isDead)
        {
            Debug.Log("Player has died");
            isDead = true;
            ResetPosition();
        }
    }

    void ResetPosition()
    {
        playerRb.transform.position = StartPosition;
        playerRb.velocity = Vector2.zero;
        isDead = false;
    }

}
