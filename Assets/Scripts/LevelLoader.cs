using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {
    [SerializeField]private SoundManager soundManager;

    void Awake() {
        soundManager.Play(soundManager.geeseHonk1);
    }

    public void LoadLevel() {
        soundManager.Play(soundManager.geeseHonk1);
        StartCoroutine(LoadScene("Endless"));
    }

    IEnumerator LoadScene(string scene) {
        yield return new WaitForSeconds((float) 0.3);
        SceneManager.LoadScene(scene);
    }

    public void QuitGame() {
        Application.Quit();
    }
}
