using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator _animator;
    private bool _isCheering;
    private int _CheeringHash;
    public static bool isWin;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _CheeringHash = Animator.StringToHash("isCheering");
    }

    // Update is called once per frame
    void Update()
    {
        _isCheering = GameManager.Instance._isGameHashGameOver ? true : false;
        _animator.SetBool(_CheeringHash, _isCheering);
    }
}
