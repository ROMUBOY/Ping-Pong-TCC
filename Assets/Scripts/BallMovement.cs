using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Invoke("LaunchBall", 3f);
    }

    void LaunchBall()
    {
        float randomDirection = Random.Range(0, 2) * 2 - 1; // -1 ou 1
        rb.velocity = new Vector2(randomDirection, Random.Range(-1f, 1f)) * speed;
    }
}
