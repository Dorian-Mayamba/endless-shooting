using System;
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

        System.Random rnd = new System.Random();
        int value  = rnd.Next(1, 7);

        switch (value) {
            case 1:
                SoundManager.instance.Play(SoundManager.instance.geeseHonk1);
                break;
            case 2:
                SoundManager.instance.Play(SoundManager.instance.geeseHonk2);
                break;
            case 3:
                SoundManager.instance.Play(SoundManager.instance.geeseHonk3);
            break;
                case 4:
                SoundManager.instance.Play(SoundManager.instance.geeseHonk4);
            break;
                case 5:
                SoundManager.instance.Play(SoundManager.instance.geeseHonk5);
            break;
            case 6:
                SoundManager.instance.Play(SoundManager.instance.geeseHonk6);
                break;
        }
        }
    }

    
}
