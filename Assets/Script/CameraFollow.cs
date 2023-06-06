using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform player;
    public float followSpeed = 1f;

    void Update() {
        // Get the player's position and rotation.
        Vector2 playerPosition = player.position;
        Quaternion playerRotation = player.rotation;

        // Set the camera's position and rotation to follow the player.
        transform.position = playerPosition + Vector2.right * followSpeed * Time.deltaTime;
        transform.rotation = playerRotation;
    }
}
