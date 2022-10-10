using UnityEngine;

public class CameraMainController : MonoBehaviour
{

    public Transform posLookAt;
    public Transform cameraTransform;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraTransform.LookAt(posLookAt, Vector3.left);
    }
}
