using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreViewer : MonoBehaviour
{
    [SerializeField] 
    private TextMeshProUGUI _text;


    [SerializeField]
    private Score scoreObj;

    void Update()
    {
        _text.text = scoreObj._score.ToString();
    }
}
