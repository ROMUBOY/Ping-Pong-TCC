using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    public AudioClip[] impactSounds;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Invoke("LaunchBall", 3f);
        audioSource = GetComponent<AudioSource>();
    }

    void LaunchBall()
    {
        float randomDirection = Random.Range(0, 2) * 2 - 1; // -1 ou 1
        rb.velocity = new Vector2(randomDirection, Random.Range(-1f, 1f)) * speed;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        audioSource.clip = impactSounds[Random.Range(0, impactSounds.Length)];
        audioSource.Play();        
    }

    public void DestroyBall()
    {
        rb.velocity = Vector2.zero;
        GetComponent<Animator>().SetBool("ball_poped",true);
    }
}
