using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControl : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float leftTarget, rightTarget;

    GameManager gameManager;
    private void Start()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if(gameManager.gameOver)
        {
            return;
        }
        float horizontal = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * horizontal * Time.deltaTime * speed);

        if (transform.position.x < leftTarget) 
        {
            transform.position = new Vector2(leftTarget, transform.position.y);
        }
        if (transform.position.x > rightTarget)
        {
            transform.position = new Vector2(rightTarget, transform.position.y);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "LiveBall")
        {
            gameManager.Lives(1);
            Destroy(collision.gameObject);
        }
        if ( collision.gameObject.tag == "ScorBall")
        {
            gameManager.Scor(50);
            Destroy(collision.gameObject);
        }
    }
}
