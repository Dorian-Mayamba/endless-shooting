using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour {
    public float PlayerSpeed;
    private Rigidbody2D _rigidBody;
    private Vector2 _playerDirection;

    [SerializeField]private PlayerScore playerScore;

    void Start() {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update() {
        float directionY = Input.GetAxis("Vertical");
        _playerDirection = new Vector2(0, directionY).normalized;
    }

    void FixedUpdate() {
        _rigidBody.velocity = new Vector2(0, _playerDirection.y * PlayerSpeed);
    }
}
