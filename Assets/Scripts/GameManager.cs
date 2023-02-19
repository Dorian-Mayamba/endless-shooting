using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Player player;

    [SerializeField] TextMeshProUGUI text;

    public static GameManager instance;

    void Awake()
    {
        if(instance == null){
            instance = this;
        }
    }
    void Update()
    {
        
    }

    public void updateTextLevel(int level)
    {
        text.text = string.Format("level {0}", level);
    }

    public void decreaseSpawnRate()
    {
        GetComponentInChildren<EnemySpawner>().TimeBetweenSpawn-=2;
    }

    public void DecreaseSpawnRate(float amount)
    {
        GetComponentInChildren<EnemySpawner>().TimeBetweenSpawn-=amount;
    }

    public void IncreaseEnemySpeed()
    {
        
    }

    
}
