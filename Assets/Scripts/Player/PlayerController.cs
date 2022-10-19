using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{   
    private CharacterController _characterController;
    private PlayerInputAction _playerInputActions;
    private Animator _animator;
    [SerializeField]
    private float _speed = 0.1f;
    private Vector2 _inputMove;
    [SerializeField]
    private float _forceMagnitude;
    private float _velocity;
    private int _VelocityHash;

    // public GameObject[] choiceCameraFreeLook;

    // public int id;
    // private static PlayerController _instance = null;
    // public static PlayerController Instance
    // {
    //     get {
    //         if (_instance == null)
    //         {
    //             _instance = GameObject.FindObjectOfType<PlayerController>();
    //             if (_instance == null)
    //             {
    //                 GameObject playerController = new GameObject("playerController");
    //                 _instance = playerController.AddComponent<PlayerController>();

    //                 DontDestroyOnLoad(playerController);
    //             }
    //         }
    //         return _instance;
    //     }
    // }

    private void Awake() {

        // if(_instance == null)
        // {
        //     _instance = this;
        // }
        // else
        // {
        //     Destroy(gameObject);
        // }
            _characterController = GetComponent<CharacterController>();
            _playerInputActions = new PlayerInputAction(); 
            
            _playerInputActions.Player.Move.performed += SetDirMove;
            _playerInputActions.Player.Move.canceled += SetDirMove;
        }

    private void Start() {
            // FindObjectOfType<AudioManager>().Stop("Theme");
        _animator = GetComponent<Animator>();
        _VelocityHash = Animator.StringToHash("Velocity");

        // for (int i = 0; i < choiceCameraFreeLook.Length; i++)
        // {
        //     if (i == PlayerPrefs.GetInt(PrefConst.CUR_PLAYER_ID))
        //     {
        //         choiceCameraFreeLook[i].SetActive(true);
        //     }
        // }
    }
    private void OnEnable() {
        _playerInputActions.Enable();
            // FindObjectOfType<AudioManager>().Play("Horror");
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

    private void OnDestroy() {
            _playerInputActions.Player.Move.performed -= SetDirMove;
            _playerInputActions.Player.Move.canceled -= SetDirMove;
        }
    }

