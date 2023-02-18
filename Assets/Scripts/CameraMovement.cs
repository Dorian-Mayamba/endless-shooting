using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public float CameraSpeed;

    void Update() {
        transform.position += new Vector3(CameraSpeed * Time.deltaTime, 0, 0);
    }
}
