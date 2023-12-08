using UnityEngine;

public class SecondPlayerRacket : Racket
{
    public float speed;

    public Rigidbody2D ballRigidBody;

    private void FixedUpdate()
    {
        if (ballRigidBody.velocity.x > 0.0f)
        {
            if (ballRigidBody.position.y > transform.position.y)
            {
                rigidbody.AddForce(Vector2.up * speed);
            }
            else if (ballRigidBody.velocity.y < transform.position.y)
            {
                rigidbody.AddForce(Vector2.down * speed);
            }
        }
        else
        {
            if (transform.position.y > 0.0f)
            {
                rigidbody.AddForce(Vector2.down * speed);
            }
            else if (transform.position.y < 0.0f)
            {
                rigidbody.AddForce(Vector2.up * speed);
            }
        }
    }
}
