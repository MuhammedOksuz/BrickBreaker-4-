using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveUp : MonoBehaviour
{
    Rigidbody2D liveBallRb;
    [SerializeField] float speed;
    private void Awake()
    {
        liveBallRb = GetComponent<Rigidbody2D>();
        liveBallRb.AddForce(new Vector2(0, speed));
    }
}
