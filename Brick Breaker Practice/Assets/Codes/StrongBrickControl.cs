using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrongBrickControl : MonoBehaviour
{
    [SerializeField] Sprite brickBroken;
    int counter = 0;
    [SerializeField] GameObject partical;

    GameManager gameManager;
    [SerializeField] GameObject obje;

    private void Start()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball") 
        {
            counter++;
            if (counter == 1)
            {
                GetComponent<SpriteRenderer>().sprite = brickBroken;
            }
            else
            {
                Instantiate(partical, transform.position, transform.rotation);
                Destroy(gameObject);
                gameManager.Scor(20);
                int random = Random.Range(1, 101);
                if (random > 70)
                {
                    Instantiate(obje, transform.position, transform.rotation);
                }
            }
        }
    }

}
