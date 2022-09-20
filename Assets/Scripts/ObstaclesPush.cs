using UnityEngine;
public class ObstaclesPush : MonoBehaviour
{
    [SerializeField]
    private float forceMagnitude;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit) 
    {
        Rigidbody rg = hit.collider.attachedRigidbody;
        
        if (rg != null)
        {
            Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
            forceDirection.y = 0;
            forceDirection.Normalize();

            rg.AddForceAtPosition(forceDirection*forceMagnitude, transform.position, ForceMode.Impulse);
        }
    }
}
