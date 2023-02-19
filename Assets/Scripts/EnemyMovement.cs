using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public int EnemyMovementSpeed;

    private Rigidbody2D _enemyRigidBody;

    private Vector3 _enemyDirection;
    

    // Update is called once per frame
    void Update()
    {
        _enemyDirection = transform.position;
        _enemyDirection.x-=EnemyMovementSpeed * Time.deltaTime;
        transform.position = _enemyDirection;
    }

    private void OnCollisionEnter(Collision other) {
        //If a bullet hits it destroy the gameObject
    }

    
}
