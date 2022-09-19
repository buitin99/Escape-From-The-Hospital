using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{   
    private CharacterController _characterController;
    private PlayerInputAction _playerInputActions;
    [SerializeField]
    private float _speed = 1f;
    private Vector2 _inputMove;

    void FixedUpdate()
    {
        _inputMove = _playerInputActions.Player.Move.ReadValue<Vector2>();
        _characterController.Move(new Vector3(_inputMove.x,0,_inputMove.y)*_speed);
    }

    private void Awake() {
        _characterController = GetComponent<CharacterController>();
        _playerInputActions = new PlayerInputAction();
    }

    private void OnEnable() {
        _playerInputActions.Enable();   
    }
}
