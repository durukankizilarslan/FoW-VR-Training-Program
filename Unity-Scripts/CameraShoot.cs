using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShoot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            Rigidbody rb = go.AddComponent<Rigidbody>();
            rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
            

            //rb.AddForce(Vector3.forward * 100, ForceMode.Impulse); // Add force to object
            rb.AddForce(transform.forward * 100, ForceMode.Impulse); // Another way to write the upper command, but this time it will nulify at every update its position
            go.transform.position = gameObject.transform.position; // !! kucuk g ile yazilan gameObject scriptin atandigi objeyi temsil eder
            go.transform.rotation = gameObject.transform.rotation;
        }
    }
}
