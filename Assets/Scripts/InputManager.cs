using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;

    public bool MenuInput { get; private set; }
    public Vector2 MoveAction { get; private set; }

    private PlayerInput _playerInput;

    private InputAction _menuInputAction;
    private InputAction _moveAction;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        _playerInput = GetComponent<PlayerInput>();
        _menuInputAction = _playerInput.actions["MenuInteraction"];
        _moveAction = _playerInput.actions["Move"];
    }

    private void Update()
    {
        MenuInput = _menuInputAction.WasPressedThisFrame();
        MoveAction = _moveAction.ReadValue<Vector2>();
    }

}
