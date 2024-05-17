using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGenerator : MonoBehaviour
{
    public GameObject spherePrefab; // Assign the sphere prefab in the Unity Editor
    public float heightAbovePlane = 2.0f; // Adjust this to control the height above the plane
    public float generationInterval = 5.0f;

    void Start()
    {
        // Start generating spheres after a delay, then repeat every generationInterval seconds
        InvokeRepeating("GenerateSphere", generationInterval, generationInterval);
    }

    void GenerateSphere()
    {
        // Calculate random x and z coordinates within the bounds of the plane
        float randomX = Random.Range(-5f, 5f); // Adjust these values according to your plane size
        float randomZ = Random.Range(-5f, 5f); // Adjust these values according to your plane size

        // Get the position to instantiate the sphere
        Vector3 spawnPosition = new Vector3(randomX, heightAbovePlane, randomZ);

        // Instantiate the sphere at the calculated position
        GameObject sphere = Instantiate(spherePrefab, spawnPosition, Quaternion.identity);

        // Add Rigidbody component to the instantiated sphere
        Rigidbody sphereRigidbody = sphere.AddComponent<Rigidbody>();

        // You can adjust the Rigidbody properties as needed
        sphereRigidbody.mass = 1f; // Example: set mass to 1
        sphereRigidbody.drag = 0.5f; // Example: set drag to 0.5
        sphereRigidbody.angularDrag = 0.5f; // Example: set angular drag to 0.5
    }
}
