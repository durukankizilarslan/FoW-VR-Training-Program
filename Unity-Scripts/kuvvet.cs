using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kuvvet : MonoBehaviour

{

    GameObject kure;
    Rigidbody rb;

    public GameObject mermi;
    public AudioClip sess;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            kure = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            rb = kure.AddComponent<Rigidbody>();
            rb.AddForce(Vector3.forward * 100, (ForceMode.Impulse));

            kure.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            kure.transform.position = gameObject.transform.position;
            kure.transform.rotation = gameObject.transform.rotation;
            rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
            kure.tag = "mermi";
        }
    }
}
