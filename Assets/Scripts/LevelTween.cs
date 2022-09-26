using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTween : MonoBehaviour
{
    [SerializeField]
    private GameObject _colorWheel, _backPanel, _homeButton, _replayButton, _star1, _star2, _star3, _score,_levelSuccess;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.rotateAround(_colorWheel, Vector3.forward, -360f, 10f).setLoopClamp();
        LeanTween.scale(_levelSuccess, new Vector3(1.5f, 1.5f, 1.5f), 2f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.moveLocal(_levelSuccess, new Vector3(-30f, 747f, 2f), 0.7f).setDelay(2f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.scale(_levelSuccess, new Vector3(1f, 1f, 1f), 2f).setDelay(1.7f).setEase(LeanTweenType.easeInOutCubic);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
