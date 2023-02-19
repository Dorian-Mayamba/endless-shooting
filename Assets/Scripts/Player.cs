using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour {
    public float PlayerSpeed;

    private string target = "Enemy(Clone)";
    public int BulletSpeed;
    private Rigidbody2D _rigidBody;
    private Rigidbody2D _bulletRigidBody;
    private Vector2 _playerDirection;

    private Vector3 _playerPostion;
    [SerializeField]private GameObject bulletSpawnPoint;

    [SerializeField]private PlayerScore playerScore;
    [SerializeField]private GameObject bullet;

    public int level;

    [SerializeField] private float maxY, minY;
    private float playerHealth;

    [SerializeField] HealthBar playerBar;

    void Start() {
        _rigidBody = GetComponent<Rigidbody2D>();
        playerBar.Init();
        SetPlayerHealth(playerBar.GetSlider().maxValue);
        level = 0;
        
    }

    void Update() {
        float directionY = Input.GetAxis("Vertical");
        _playerDirection = new Vector2(0, directionY).normalized;
        if(Input.GetKeyDown(KeyCode.Space)){
            GameObject bulletObject = Instantiate(bullet, bullet.transform.position, bullet.transform.rotation);
            bulletObject.transform.SetParent(this.gameObject.transform,false);
            _bulletRigidBody = bulletObject.GetComponent<Rigidbody2D>();
        }
        if(this.playerHealth <= 0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("Gameover Scene");
        }
    }

    void FixedUpdate() {
        _rigidBody.velocity = new Vector2(0, _playerDirection.y * PlayerSpeed);
        if(_bulletRigidBody){
            _bulletRigidBody.velocity = new Vector2(BulletSpeed, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log(target .Equals(other.name));
        if(target.Equals(other.name)){
            this.playerHealth-=5;
            this.playerBar.Sethealth(this.playerHealth);
        }
    }

    public void SetPlayerHealth(float health)
    {
        this.playerHealth = health;
    }

    public void Death()
    {
        Destroy(transform.gameObject);
    }

    public float getPlayerHealth()
    {
        return this.playerHealth;
    }

    public void UpdateScore(int score)
    {
        playerScore.updateScore(score);
    }

    public int GetScore()
    {
        return this.playerScore.GetScore();
    }

    public void IncreaseLevel()
    {
        this.level++;
    }

    public int GetLevel()
    {
        return this.level;
    }
}
