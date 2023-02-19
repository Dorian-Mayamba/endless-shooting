using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour {
    public float PlayerSpeed;
    public int BulletSpeed;
    private Rigidbody2D _rigidBody;
    private Rigidbody2D _bulletRigidBody;
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
        if(Input.GetKeyDown(KeyCode.Space)){
            GameObject bulletObject = Instantiate(bullet, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
            _bulletRigidBody = bulletObject.GetComponent<Rigidbody2D>();
        }
    }

    void FixedUpdate() {
        _rigidBody.velocity = new Vector2(0, _playerDirection.y * PlayerSpeed);
        if(_bulletRigidBody){
            _bulletRigidBody.velocity = new Vector2(BulletSpeed, 0);
        }
    }
}
