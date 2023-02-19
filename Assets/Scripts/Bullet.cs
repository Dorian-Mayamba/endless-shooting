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
            transform.parent.GetComponent<Player>().UpdateScore(5);
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
