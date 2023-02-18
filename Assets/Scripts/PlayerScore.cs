using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    private int score = 0;

    [SerializeField]private TextMeshProUGUI scoreText;

    public void updateScore(int score) {
        this.score += score;
        scoreText.text = "Score: " + this.score.ToString();
        Debug.Log(string.Format("Score updated to %d", this.score));
    }
}
