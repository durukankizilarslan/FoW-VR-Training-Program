
using UnityEngine;
using UnityEngine.UIElements;


public class RandomKure : MonoBehaviour
{
    // Declare Game Object
    GameObject kure;
    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        kure = GameObject.CreatePrimitive(PrimitiveType.Sphere); // Kure olustur
        rb = kure.AddComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         
        // Create an instance of System.Random class
        //System.Random random = new System.Random();

        //  Create random coordinates
        float randomX = Random.Range(-30, 31);
        float randomY = Random.Range(0, 51);
        float randomZ = Random.Range(-30, 31);


        if (Input.GetKeyDown(KeyCode.Space)) // Space e basilirsa
        {
            kure = GameObject.CreatePrimitive(PrimitiveType.Sphere); // Kure Olustur
            rb = kure.AddComponent<Rigidbody>();  // Rigidbody ozellikleri ver 
            MeshRenderer mesh = kure.GetComponent<MeshRenderer>(); // MeshRenderer ozellikleri ver
            mesh.material.color = UnityEngine.Random.ColorHSV();

            kure.transform.position = new Vector3(randomX,randomY, randomZ);

        }


    }
}
