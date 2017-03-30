using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject newAsteroid;
    public Vector2 spawnValue;
    public int asteroidCount;

    public float spawnWait;
    public float startWait;
    public float waveWait; 

    // 10 | 0, 4, 8 
	
	void Start () {
        StartCoroutine(SpawnWaves());
	}


    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < asteroidCount; i++)
            {
                Vector2 spawnPisition = new Vector2(spawnValue.x, Random.Range(-spawnValue.y, spawnValue.y));
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(newAsteroid.gameObject, spawnPisition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
        
    }

	void Update () {
       
    }
}
