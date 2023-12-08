using UnityEngine;
using UnityEngine.InputSystem;

public class Racket : MonoBehaviour
{
    public InputAction racketControls;

    protected new Rigidbody2D rigidbody;

    private void OnEnable()
    {
        racketControls.Enable();
    }

    private void OnDisable()
    {
        racketControls.Disable();
    }

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
}
