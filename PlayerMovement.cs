using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveAxis;
    

    // Update is called once per frame
    void Update()
    {
        float maoveX = Input.GetAxisRaw("Horizontal");
        float maoveY = Input.GetAxisRaw("Vertical");

        moveAxis = new Vector2(maoveX, maoveY).normalized; //.normalized makes the movment consistant
    }

    void FixedUpdate() 
    {
        rb.velocity = new Vector2(moveAxis.x * moveSpeed, moveAxis.y * moveSpeed);
    }

}
