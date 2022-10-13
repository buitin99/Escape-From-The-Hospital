using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisiblePlayer : MonoBehaviour
{

    private GameObject[] _bodyCharacters;
    public GameObject potion;
    public static bool isInvisible = false;
    private float currInv;
    private float maxInv = 5;

    [SerializeField]
    private InvisibleBar _invisibleBar;
    // Start is called before the first frame update
    void Start()
    {
        _bodyCharacters = GameObject.FindGameObjectsWithTag("Invisible");
        currInv = maxInv;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Potion"))
        {
            potion.SetActive(false);
            // other.GetComponent<PlayerPowerUp>().Invisible();
            FindObjectOfType<PlayerPowerUp>().Invisible();

            foreach(GameObject b in _bodyCharacters)
            {
                b.SetActive(false);
            }

            StartCoroutine(Visible());
            isInvisible = true;
            StartCoroutine(TimerCount());
            // _invisibleBar.UpdateInvisibleBar(currInv,maxInv);
        }
    }

    private IEnumerator Visible()
    {   
        yield return new WaitForSeconds(5);
        foreach(GameObject b in _bodyCharacters)
        {
            b.SetActive(true);
        }
        isInvisible = false;
    }

    private IEnumerator TimerCount()
    {
        _invisibleBar.UpdateInvisibleBar(currInv,maxInv);
        while(currInv != 0)
        {
            yield return new WaitForSeconds(1);
            currInv--;
            _invisibleBar.UpdateInvisibleBar(currInv,maxInv);
        }
    } 
}
