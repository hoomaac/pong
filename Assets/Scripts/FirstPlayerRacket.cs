using UnityEngine;

public class FirstPlayerRacket : Racket
{
    private Vector2 _position = Vector2.zero;
    public float speed = 15.0f;

    private void Update()
    {
        _position = racketControls.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rigidbody.velocity = new Vector2(_position.x * speed, _position.y * speed);
        if (_position.sqrMagnitude != 0)
        {
            rigidbody.AddForce(_position * speed);
        }
    }
}
