using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public Rigidbody2D rb;

    private void Update()
    {
        
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(x: speed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(x: -speed, rb.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce((Vector2)(transform.up * jumpForce), ForceMode2D.Impulse);
        }
    }
}
