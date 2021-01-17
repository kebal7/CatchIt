using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _collectable;

    [SerializeField]
    private float timer,spwanTime,minSpawnTime,decreaseSpawnRate;

    void FixedUpdate()
    {
        if(spwanTime > minSpawnTime)
        {
            spwanTime -= decreaseSpawnRate * Time.deltaTime;
        }
        
        if(timer >= spwanTime)
        {
            GameObject newCOllectable = Instantiate(_collectable);
            newCOllectable.transform.position = transform.position + new Vector3(Random.Range(-2,2), 0,0);
            newCOllectable.tag = "Collectable";
            timer = 0;
            Destroy(newCOllectable,15);
        }
        
        timer += Time.deltaTime;
    }
}
