using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float respawnTime = 1f;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(spawnWave());
    }

    public void spawnEnemy()
    {
        GameObject  enemy = Instantiate(enemyPrefab) as GameObject;
        enemy.transform.position = new Vector2(screenBounds.x, -2.802f);   
    }

    IEnumerator spawnWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
        
    }

   
}
