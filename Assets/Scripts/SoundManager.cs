using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource geeseHonk1;
    public AudioSource geeseHonk2;
    public AudioSource geeseHonk3;
    public AudioSource geeseHonk4;
    public AudioSource geeseHonk5;
    public AudioSource geeseHonk6;

    public static SoundManager instance;

    void Awake() {
        if (instance == null) {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }

    public void Play(AudioSource sound) {
        Debug.Log("Playing " + sound.ToString());
        sound.PlayOneShot(sound.clip);
    }
}
