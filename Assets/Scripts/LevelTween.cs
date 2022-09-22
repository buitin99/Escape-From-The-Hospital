using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTween : MonoBehaviour
{
    [SerializeField] GameObject colorWheel,levelSucess;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.rotateAround(colorWheel, Vector3.forward, -360f, 10f).setLoopClamp();
        // LeanTween.scale(levelSucess, new Vector3(1.5f, 1.5f, 1.5f), 2f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic).setOnComplete(LevelComplete);
        LeanTween.moveLocal(levelSucess, new Vector3(-30f, 747f, 2f), 0.7f).setDelay(2f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.scale(levelSucess, new Vector3(1f, 1f, 1f), 2f).setDelay(1.7f).setEase(LeanTweenType.easeInOutCubic);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
