using UnityEngine;
using UnityEngine.InputSystem;

public class Racket : MonoBehaviour
{
    public InputAction racketControls;

    protected Rigidbody2D m_rigidbody;

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
        m_rigidbody = GetComponent<Rigidbody2D>();
    }
}
