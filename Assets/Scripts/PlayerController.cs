using UnityEngine;
using UnityEngine.InputSystem;

    public class PlayerController : MonoBehaviour
    {   
        private CharacterController _characterController;
        private PlayerInputAction _playerInputActions;
        [SerializeField]
        private float _speed = 1f;
        private Vector2 _inputMove;
        [SerializeField]
        private float _forceMagnitude;


        private void Awake() {
            _characterController = GetComponent<CharacterController>();
            _playerInputActions = new PlayerInputAction(); 
            
            _playerInputActions.Player.Move.performed += SetDirMove;
            _playerInputActions.Player.Move.canceled += SetDirMove;

        }
        private void OnEnable() {
            _playerInputActions.Enable();   
        }

        void FixedUpdate()
        {
            _characterController.Move(new Vector3(_inputMove.x,0,_inputMove.y)*_speed);

        }
        
        private void SetDirMove( InputAction.CallbackContext ctx) {
            _inputMove = ctx.ReadValue<Vector2>();
        }

        private void OnDestroy() {
            _playerInputActions.Player.Move.performed -= SetDirMove;
            _playerInputActions.Player.Move.canceled -= SetDirMove;
        }

         private void OnControllerColliderHit(ControllerColliderHit hit) 
        {
            Rigidbody _rg = hit.collider.attachedRigidbody;
            
            if (_rg != null)
            {
                Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
                forceDirection.y = 0;
                forceDirection.Normalize();

                _rg.AddForceAtPosition(forceDirection*_forceMagnitude, transform.position, ForceMode.Impulse);
            }
        }

        private void OnCollisionEnter(Collision other) {
            Debug.Log(other);
        }

    }

