using System.Net;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBallMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {                
        switch(other.name)
        {
            case "PongPlayer1":
                rb.velocity = new Vector2(-GameObject.Find("PongPlayer1").transform.position.x, -GameObject.Find("PongPlayer1").transform.position.y);
                Debug.Log(GameObject.Find("PongPlayer1").transform.position.x+", "+GameObject.Find("PongPlayer1").transform.position.y);
            break;
            case "PongPlayer2":
                rb.velocity = new Vector2(-GameObject.Find("PongPlayer2").transform.position.x, -GameObject.Find("PongPlayer1").transform.position.y);
            break;    
        }
    }
}
