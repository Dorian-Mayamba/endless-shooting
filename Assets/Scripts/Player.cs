using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour {
    public float PlayerSpeed;
    public int BulletSpeed;
    private Rigidbody2D _rigidBody;
    private Vector2 _playerDirection;
    [SerializeField]private GameObject bulletSpawnPoint;

    [SerializeField]private PlayerScore playerScore;
    [SerializeField]private GameObject bullet;

    void Start() {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update() {
        float directionY = Input.GetAxis("Vertical");
        _playerDirection = new Vector2(0, directionY).normalized;
        if(Input.GetKey(KeyCode.Space)){
            Debug.Log("Space button pressed");
            GameObject bulletObject = Instantiate(bullet, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
            
        }
    }

    void FixedUpdate() {
        _rigidBody.velocity = new Vector2(0, _playerDirection.y * PlayerSpeed);
    }
}
