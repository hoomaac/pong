using UnityEngine;

public class Bouncy : MonoBehaviour
{
    public float strenght;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Ball>(out var ballMovement))
        {
            var normalSurface = collision.GetContact(0).normal;
            ballMovement.AddForce(-normalSurface * strenght);
        }
    }
}
