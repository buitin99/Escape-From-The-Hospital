using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlotManager : MonoBehaviour
{   
    [SerializeField]
    private GameObject _plotManager;

    [SerializeField]
    private GameObject[] _plotList;

    [SerializeField]
    private TMP_Text _plotText;
    [SerializeField]
    private TMP_Text[] _plotTextList;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForPlot());
    }

    private IEnumerator WaitForPlot()
    {
        for (int i = 0; i < _plotTextList.Length; i++)
        {
            _plotText.text = _plotTextList[i].text;
            yield return new WaitForSeconds(2);
            _plotList[i].SetActive(false);
        }
        _plotManager.SetActive(false);
    }

}
