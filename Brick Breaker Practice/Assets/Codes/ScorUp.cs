using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorUp : MonoBehaviour
{
    Rigidbody2D scorBallRb;
    [SerializeField] float speed;
    private void Awake()
    {
        scorBallRb = GetComponent<Rigidbody2D>();
        scorBallRb.AddForce(new Vector2(0, speed));
    }
}
