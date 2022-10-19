using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Vector3 Origin;
    public Vector3 Destination;
    private bool flag;

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {
            StartCoroutine(moveObjectTo());
        }else
        {
            StartCoroutine(moveCameraFrom());
        }
    }

    public IEnumerator moveCameraFrom() {
        float totalMovementTime = 5f;
        float currentMovementTime = 0f;
        while (Vector3.Distance(transform.localPosition, Destination) > 0.1f) 
        {
            currentMovementTime += Time.deltaTime;
            transform.localPosition = Vector3.Lerp(Origin, Destination, currentMovementTime / totalMovementTime);
            yield return null;
        }
        flag = true;    
    }

    public IEnumerator moveObjectTo() {
        float totalMovementTime = 5f;
        float currentMovementTime = 0f;
        while (Vector3.Distance(transform.localPosition, Origin) > 0.1f) 
        {
            currentMovementTime += Time.deltaTime;
            transform.localPosition = Vector3.Lerp(Destination, Origin, currentMovementTime / totalMovementTime);
            yield return null;
        }
        flag = false;    
    }




}
