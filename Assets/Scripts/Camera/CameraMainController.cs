using UnityEngine;

public class CameraMainController : MonoBehaviour
{

    public Transform posLookAt;
    public Transform cameraTransform;

    // Update is called once per frame
    void Update()
    {
        cameraTransform.LookAt(posLookAt, Vector3.left);
    }
}
