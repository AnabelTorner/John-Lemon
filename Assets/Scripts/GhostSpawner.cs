using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpawner : MonoBehaviour
{
    public Transform spawnPos;
    private float timer = 0.0f;

    void Update()
    {
        if (this.gameObject.name == "Ghost"){ 
            
            timer += Time.deltaTime;

            if (timer >= 1){
                SpawnEnemy();
                timer = 0;
            }
        }
    }

    void SpawnEnemy()
    {
        Instantiate(this, spawnPos.transform.position, Quaternion.identity);
    }
}
