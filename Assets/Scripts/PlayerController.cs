using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

    public class PlayerController : MonoBehaviour
    {   
        private CharacterController _characterController;
        private PlayerInputAction _playerInputActions;
        private Animator _animator;
        [SerializeField]
        private float _speed = 0.5f;
        private Vector2 _inputMove;
        [SerializeField]
        private float _forceMagnitude;
        private float _velocity;
        private int _VelocityHash;
        [SerializeField]
        private GameObject _playerGO;
        [SerializeField]
        private Transform _destination;
        [SerializeField]
        private Transform _player; 

        private void Awake() {
            _characterController = GetComponent<CharacterController>();
            _playerInputActions = new PlayerInputAction(); 
            
            _playerInputActions.Player.Move.performed += SetDirMove;
            _playerInputActions.Player.Move.canceled += SetDirMove;
        }

        private void Start() {
            _animator = GetComponent<Animator>();
            _VelocityHash = Animator.StringToHash("Velocity");
        }
        private void OnEnable() {
            _playerInputActions.Enable();
        }

        void FixedUpdate()
        {   
            if(new Vector3(_inputMove.x,0,_inputMove.y) != Vector3.zero) {
                transform.rotation = Quaternion.LookRotation(new Vector3(_inputMove.x,0,_inputMove.y));
            }
            _characterController.Move(new Vector3(_inputMove.x,0,_inputMove.y)*_speed);
            _animator.SetFloat(_VelocityHash, _velocity);
        }
        
        private void SetDirMove( InputAction.CallbackContext ctx) {
            _inputMove = ctx.ReadValue<Vector2>();
            _velocity = Vector3.Distance(Vector3.zero, new Vector3(_inputMove.x,0,_inputMove.y));
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

        private void OnTriggerEnter(Collider other) {
            if (other.CompareTag("Teleport"))
            {
                _playerGO.SetActive(false);
                _player.position = _destination.position;
                _playerGO.SetActive(true);
            }
        }

        private void OnDestroy() {
            _playerInputActions.Player.Move.performed -= SetDirMove;
            _playerInputActions.Player.Move.canceled -= SetDirMove;
        }

    }

