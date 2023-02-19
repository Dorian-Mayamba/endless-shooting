using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    string target = "Enemy(Clone)";

    [SerializeField]private GameObject explosion; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(target.Equals(other.name)){
            Player player = transform.parent.GetComponent<Player>();
            player.UpdateScore(5);
            switch(player.GetScore()){
            case 10:
                player.IncreaseLevel();
                GameManager.instance.updateTextLevel(player.GetLevel());
                break;
            case 20:
                player.IncreaseLevel();
                GameManager.instance.updateTextLevel(player.GetLevel());
                break;
            case 30:
                player.IncreaseLevel();
                GameManager.instance.updateTextLevel(player.GetLevel());
                break;
            case 40:
                player.IncreaseLevel();
                GameManager.instance.updateTextLevel(player.GetLevel());
                break;
            case 50:
                player.IncreaseLevel();
                GameManager.instance.updateTextLevel(player.GetLevel());
                break;
        }
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
