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
            SpawnGoose();
            SpawnTime = Time.time + TimeBetweenSpawn;
        }
    }

    void SpawnGoose() {
        float RandomX = Random.Range(MinX, MaxX);
        float RandomY = Random.Range(MinY, MaxX);

        GameObject gooseEnemy = Instantiate(Enemy, transform.position + new Vector3(RandomX, RandomY, 0), transform.rotation);

        StartCoroutine(DestroyGooseLater(gooseEnemy));
    }

    IEnumerator DestroyGooseLater(GameObject goose) {
        yield return new WaitForSeconds(3);
        Debug.Log("Destroying goose " + goose.GetInstanceID() + "...");
        DestroyImmediate(goose, true);
    }

}
