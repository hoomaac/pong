using UnityEngine;

public class FirstPlayerRacket : Racket
{
    private Vector2 m_position = Vector2.zero;
    public float speed = 15.0f;

    private void Update()
    {
        m_position = racketControls.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        m_rigidbody.velocity = new Vector2(m_position.x * speed, m_position.y * speed);
        if (m_position.sqrMagnitude != 0 )
        {
            m_rigidbody.AddForce(m_position * speed);
        }
    }
}
