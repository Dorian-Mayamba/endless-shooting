using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {
    public void LoadLevel() {
        SceneManager.LoadScene("Endless");
    }

    public void QuitGame() {
        Application.Quit();
    }
}
