using UnityEngine;

public class Bouncy : MonoBehaviour
{
    public float strenght;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ballMovement = collision.gameObject.GetComponent<Ball>();
        if (ballMovement != null)
        {
            Vector2 normalSurface = collision.GetContact(0).normal;
            ballMovement.AddForce(-normalSurface * strenght);
        }
    }
}
