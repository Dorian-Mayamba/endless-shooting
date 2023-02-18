using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    public GameObject Enemy;
    public float MaxX;
    public float MinX;
    public float MaxY;
    public float MinY;
    public float TimeBetweenSpawn;
    private float SpawnTime;

    void Update() {
        if (Time.time > SpawnTime) {
            Spawn();
            SpawnTime = Time.time + TimeBetweenSpawn;
        }
    }

    void Spawn() {
        float RandomX = Random.Range(MinX, MaxX);
        float RandomY = Random.Range(MinY, MaxX);

        Instantiate(Enemy, transform.position + new Vector3(RandomX, RandomY, 0), transform.rotation);
    }

    // add ienumerator method to destroy instances
}
