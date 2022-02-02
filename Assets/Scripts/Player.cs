using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float upForce = 350;

    private bool isDead;
    private Rigidbody2D playerRb;
    private Animator playerAnimator;
    AudioSource audio;
   
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isDead)
        {
            playerRb.velocity = Vector2.zero;
            playerRb.AddForce(Vector2.up * 350f);
            audio.Play();

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        playerAnimator.SetTrigger("Daño");
        GameManager.Instance.GameOver();
    }
}
