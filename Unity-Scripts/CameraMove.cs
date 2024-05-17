using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the speed of camera movement
    public float mouseSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get input from arrow keys
        float horizontalInput = Input.GetAxis("Horizontal"); // Input uzerinden horizontal harekete erisiyor
        float verticalInput = Input.GetAxis("Vertical"); //Input uzerinden vertical harekete erisim sagliyor
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");


        // Calculate movement direction based on input
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.deltaTime;

        // Apply movement to the camera's position
        transform.Translate(movement);

        // Apply movement with mouse
        transform.Rotate(Vector3.up * mouseX);
        transform.Rotate(Vector3.left * mouseY);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            Rigidbody rb = go.AddComponent<Rigidbody>();
            rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;

            //rb.AddForce(Vector3.forward * 100, ForceMode.Impulse); // Add force to object
            rb.AddForce(transform.forward * 10, ForceMode.Impulse); // Another way to write the upper command, but this time it will nulify at every update its position
            go.transform.position = gameObject.transform.position; // !! kucuk g ile yazilan gameObject scriptin atandigi objeyi temsil eder
            go.transform.rotation = gameObject.transform.rotation;
        }
    }
}
