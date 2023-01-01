using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour // Bir y�zeyin topa etkisinin daha farkl� olmas�n� isteyebiliriz
{                                          // �rne�in topa vuran objenin topu h�zland�rmas� vs.
    public float bounceStrenght;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null) // if it was null, the object collide with was not the ball so.. if it was not null it was the ball
        {                 // if it was ball the surface hit, add force to increase the velocity of the ball .

            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal*this.bounceStrenght);
        }
    }
}
