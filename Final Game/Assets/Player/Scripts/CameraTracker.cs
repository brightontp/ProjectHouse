using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracker : MonoBehaviour
{

    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //Hides the cursor to make it easier
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; //gets the x position of the mouse
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime; //gets the y position of the mouse

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 45f);  //Means can't look up and down 360˚

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);  //rotates camera for y rotation
        playerBody.Rotate(Vector3.up * mouseX); //rotates player for x rotation
    }
}