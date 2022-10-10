using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPatrolController : MonoBehaviour
{
    public Vector3 Origin;
    public Vector3 Destination;
    private bool flag;
    private float speed = 0.0001f;
    float totalMovementTime = 5f; //the amount of time you want the movement to take
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!flag)
            {
                while (Vector3.Distance(transform.localPosition, Destination) > 0.1f) 
                {
                    transform.localPosition = Vector3.Lerp(transform.localPosition, Destination, speed * Time.deltaTime);
                    flag = true;
                }
            }
            else if (flag)
            {
                while (Vector3.Distance(transform.localPosition, Origin) > 0.1f) 
                {

                    transform.localPosition = Vector3.Lerp(transform.localPosition, Origin, speed * Time.deltaTime);
                    flag = false;
                }
            } 
    }

    // public IEnumerator moveObject() {
    // float currentMovementTime = 0f;//The amount of time that has passed
    // while(true){
            
    //     yield return null;
    // }    
    }

