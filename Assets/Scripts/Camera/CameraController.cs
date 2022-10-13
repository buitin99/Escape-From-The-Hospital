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
            StartCoroutine(moveObject2());
        }else
        {
            StartCoroutine(moveObject());
        }
    }

    public IEnumerator moveObject() {
    float totalMovementTime = 5f; //the amount of time you want the movement to take
    float currentMovementTime = 0f;//The amount of time that has passed
        while (Vector3.Distance(transform.localPosition, Destination) > 0.1f) 
        {
            currentMovementTime += Time.deltaTime;
            transform.localPosition = Vector3.Lerp(Origin, Destination, currentMovementTime / totalMovementTime);
            yield return null;
        }
        flag = true;    
    }

    public IEnumerator moveObject2() {
    float totalMovementTime = 5f; //the amount of time you want the movement to take
    float currentMovementTime = 0f;//The amount of time that has passed
        while (Vector3.Distance(transform.localPosition, Origin) > 0.1f) 
        {
            currentMovementTime += Time.deltaTime;
            transform.localPosition = Vector3.Lerp(Destination, Origin, currentMovementTime / totalMovementTime);
            yield return null;
        }
        flag = false;    
    }




}
