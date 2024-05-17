using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collis ENTER Çalýþtý");
        Destroy(gameObject);
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Collis STAY Çalýþtý");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Collis EXIT Çalýþtý");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger ENTER Çalýþtý");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger STAY Çalýþtý");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
