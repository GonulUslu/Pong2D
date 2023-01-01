using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle // ComputerPaddle Script will track the position of the ball.
{
    public Rigidbody2D ball;

    private void FixedUpdate()
    {
        if (ball.velocity.x > 0.0f) //if the ball moves right
        {
            if (ball.position.y > transform.position.y) // if the ball above the computerpaddle
            {
                rb.AddForce(Vector2.up * speed);
            }
            else if (ball.position.y < transform.position.y) // !!! We use else if here because if the position
            {                                                          // .. equal we don't want paddle to move
                rb.AddForce(Vector2.down * speed);                // We do not need another else with this !!
            }      
        }

        else // After the ComputerPaddle hit the ball, it will move to middle.
        {
            if (transform.position.y > 0.0f)
            {
                rb.AddForce(Vector2.down * speed);
            }
            else if (transform.position.y <0.0f)
            {
                rb.AddForce(Vector2.up * speed);
            }
        }
    }
}
