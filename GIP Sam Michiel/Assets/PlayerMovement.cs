using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    void Update()
    {
        if (movement.x == 0) movement.y = Input.GetAxisRaw("Vertical");
        if (movement.y == 0) movement.x = Input.GetAxisRaw("Horizontal");
    }

    void fixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
