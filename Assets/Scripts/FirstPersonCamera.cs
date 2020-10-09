using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public float rotationSpeed = 6.0f;
    public float movementSpeed = 3.0f;
    private float rotationX;

    void CameraMovement()
    {
        float y = Input.GetAxis("Mouse X") * rotationSpeed;
        rotationX += Input.GetAxis("Mouse Y") * rotationSpeed;

        rotationX = Mathf.Clamp(rotationX, 0.0f, 0.0f);

        transform.eulerAngles = new Vector3(-rotationX, transform.eulerAngles.y + y, 0);
    }

    void PlayerMovement ()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * movementSpeed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        CameraMovement();
        PlayerMovement();
    }
}
