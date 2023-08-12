using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickControl : MonoBehaviour
{
    [SerializeField] GameObject partical;
    int scorCounter;
    GameManager gameManager;
    [SerializeField] GameObject obje;
    private void Start()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Instantiate(partical, transform.position, transform.rotation);
            Destroy(this.gameObject);
            gameManager.Scor(10);
            int random = Random.Range(1, 101);
            if (random > 60)
            {
                Instantiate(obje, transform.position, transform.rotation);
            }
        }
    }
}
