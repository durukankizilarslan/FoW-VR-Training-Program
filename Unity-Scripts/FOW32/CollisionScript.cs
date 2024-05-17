using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collis ENTER �al��t�");
        Destroy(gameObject);
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Collis STAY �al��t�");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Collis EXIT �al��t�");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger ENTER �al��t�");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger STAY �al��t�");
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
