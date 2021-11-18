using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PongPlayerControll : MonoBehaviour
{   
    private Rigidbody2D rb;
    public float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Physics2D.gravity = Vector2.zero;
    } 
    public void Up()
    {
        rb.velocity = new Vector2(rb.velocity.x, speed);
    }

    public void Down()
    {
        rb.velocity = new Vector2(rb.velocity.x, -speed);
    }
}
