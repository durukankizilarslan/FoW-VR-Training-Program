using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject kup = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject kure = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        Vector3 position = new Vector3(1, 2, 3);
        Vector3 position2 = new Vector3(2, 3, 4);

        kup.transform.position = position;
        kure.transform.position = position2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
