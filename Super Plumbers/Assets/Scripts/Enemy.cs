using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int pointValue;
    private Rigidbody2D body;
    [SerializeField]
    private float speed;
    private Vector2 movementDirection;

 
    // Start is called before the first frame update
    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        movementDirection = Vector2.right;
    }

    // Update is called once per frame
    void Update()
    {
        Move(movementDirection);
    }

    //move enemy in a direction based on speed

    public void Move(Vector2 direction)
    {
        movementDirection = direction;
        body.velocity = new Vector2(movementDirection.x * speed, body.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            movementDirection *= -1f;
        }
    }
}
