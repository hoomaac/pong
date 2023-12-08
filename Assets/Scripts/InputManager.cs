using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;

    public bool MenuInput { get; private set; }
    public Vector2 MoveAction { get; private set; }

    private PlayerInput m_playerInput;

    private InputAction m_menuInputAction;
    private InputAction m_moveAction;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        m_playerInput = GetComponent<PlayerInput>();
        m_menuInputAction = m_playerInput.actions["MenuInteraction"];
        m_moveAction = m_playerInput.actions["Move"];
    }

    private void Update()
    {
        MenuInput = m_menuInputAction.WasPressedThisFrame();
        MoveAction = m_moveAction.ReadValue<Vector2>();
    }

}
