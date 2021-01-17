using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    [SerializeField]
    private GameObject animatingEgg,life1,life2,life3;

    [SerializeField]
    private PlayerLife _playerLife;

    [SerializeField]
    private float timer;


    void Update()
    {
        if(_playerLife.lifeLeft == 2)
        {
            life1.SetActive(false);
        }

        if(_playerLife.lifeLeft == 1)
        {
            life2.SetActive(false);
        }

        if(_playerLife.lifeLeft <= 0)
        {
            timer += Time.deltaTime;
            life3.SetActive(false);
        }


        if(timer >= 2)
        {
            gameManager.GameOver();
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Collectable")
        {
            GameObject _newAnimtionEgg = Instantiate(animatingEgg);
            _newAnimtionEgg.transform.position = other.transform.position;

            FindObjectOfType<AudioManager>().Play("eggcrack");

            _playerLife.lifeLeft -=1;

        }
    }
}
