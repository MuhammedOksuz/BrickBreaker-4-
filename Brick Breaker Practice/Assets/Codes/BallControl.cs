using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    Rigidbody2D ballRb;
    [SerializeField] float speed =500f;
    bool inPlay;
    [SerializeField] Transform ballStartPos;

    GameManager gameManager;

    private void Awake()
    {
        ballRb = GetComponent<Rigidbody2D>();
        gameManager = Object.FindObjectOfType<GameManager>();
    }
    private void Update()
    {
        if (gameManager.gameOver)
        {
            return;
        }
        if (!inPlay)
        {
            transform.position = ballStartPos.position;
        }
        if (Input.GetButtonDown("Jump") && !inPlay)
        {
            inPlay = true;
            ballRb.AddForce(Vector2.up * speed);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bottom")
        {
            ballRb.velocity = Vector2.zero;
            inPlay = false;
            gameManager.Lives(-1);
        }
    }
}
