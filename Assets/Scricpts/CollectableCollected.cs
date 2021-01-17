using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCollected : MonoBehaviour
{
    [SerializeField]
    private Score Score,HighScore;

    [SerializeField]
    private GameObject animatingTxt;

    void Start()
    {
        Score._score = 0;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Collectable")
        {
            Score._score += 100;
            Destroy(other.gameObject,0.15f);
            FindObjectOfType<AudioManager>().Play("collect");
        }

        if(Score._score > HighScore._score)
        {
            HighScore._score = Score._score;
        }

        

        GameObject _newAnimtionTxt = Instantiate(animatingTxt);
        _newAnimtionTxt.transform.position = transform.position;
        Destroy(_newAnimtionTxt,1);
    }


}
