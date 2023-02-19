using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public int EnemyMovementSpeed;

    private Rigidbody2D _enemyRigidBody;

    private Vector3 _enemyDirection;
    
    string target = "bullet(Clone)";

    // Update is called once per frame
    void Update()
    {
        _enemyDirection = transform.position;
        _enemyDirection.x-=EnemyMovementSpeed * Time.deltaTime;
        transform.position = _enemyDirection;
    }

    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    private void OnTriggerEnter2D(Collider2D other) {
        if(target.Equals(other.name))
        {
            Destroy(this.gameObject);
        }
    }

    
}
