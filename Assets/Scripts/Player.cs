using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float upForce = 350;

    private bool isDead;
    private Rigidbody2D playerRb;
    private Animator playerAnimator;
   
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isDead)
        {
            playerRb.velocity = Vector2.zero;
            playerRb.AddForce(Vector2.up * 350f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        playerAnimator.SetTrigger("Daño");
    }
}
