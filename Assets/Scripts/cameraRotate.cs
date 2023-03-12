using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRotate : MonoBehaviour
{
    public float turnSpeed = 3.0f;
    public GameObject player;

    private Transform playerTransform;
    private Vector3 offsetX;
    private float yOffset;
    private float zOffset;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.lockState = CursorLockMode.None;
    }

    void Start()
    {
        yOffset = (Camera.main.transform.position.y - player.transform.position.y) - 0.5f;
        zOffset = (Camera.main.transform.position.z - player.transform.position.z);
        playerTransform = player.transform;
        offsetX = new Vector3(playerTransform.position.x, playerTransform.position.y + yOffset, playerTransform.position.z + zOffset);
        Debug.Log("y = " + yOffset);
        Debug.Log("z = " + zOffset);
    }

    void LateUpdate()
    {
        
        if (Time.timeScale == 1)
        {
            offsetX = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offsetX;
            transform.position = playerTransform.position + offsetX;
            transform.LookAt(playerTransform.position);
        }
    }
}
