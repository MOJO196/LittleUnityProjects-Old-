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
        rb.velocity = new Vector2(speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {                
        switch(other.name)
        {
            case "DeathZone1":
                //Player2 Scored
                PongScoreManager.instance.Score(2);
                if (PongScoreManager.instance.Score(0))
                    Destroy(gameObject);                
                StartCoroutine(Appear(1));
            break;
            case "DeathZone2":
                //Player1 Scored
                PongScoreManager.instance.Score(1);
                if (PongScoreManager.instance.Score(0))
                    Destroy(gameObject);
                StartCoroutine(Appear(2));
            break;
            default:
                rb.velocity = new Vector2(-other.transform.position.x, -other.transform.position.y);
            break;
        }
    }

    IEnumerator Appear(int pointingTowardsPlayer)
    {
        rb.position = new Vector2(0, 0);
        rb.velocity = new Vector2(0, 0);

        yield return new WaitForSeconds(1);
        
        if (pointingTowardsPlayer == 1)
            rb.velocity = new Vector2(-speed, 0);
        else if (pointingTowardsPlayer == 2)
            rb.velocity = new Vector2(speed, 0);
    }
}
