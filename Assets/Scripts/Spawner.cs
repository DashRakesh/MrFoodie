using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] fruits;
    public GameObject[] bomb;
   

    public float xBounds, yBound;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());

       
    }

    IEnumerator SpawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(1, 2));

        int randomFruit = Random.Range(0, fruits.Length);

        if (Random.value <= .6f)
            Instantiate(fruits[randomFruit],
                new Vector2(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);
        else
            Instantiate(fruits[randomFruit],
                new Vector2(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);

        StartCoroutine(SpawnRandomGameObject());


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
