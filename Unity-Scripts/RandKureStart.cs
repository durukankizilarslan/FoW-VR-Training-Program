using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandKureStart : MonoBehaviour
{
    public float kureSayisi;// Ayarlanabilir kure sayisi
    public GameObject referans;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collis ENTER Çalýþtý");
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < kureSayisi; i++)
        {
            float x = Random.Range(-30, 30);
            float y = Random.Range(1, 30);
            float z = Random.Range(-30, 30);

            GameObject kure = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            //GameObject kure = Instantiate(referans);

            Rigidbody rb = kure.AddComponent<Rigidbody>(); // Rigidbody ozellikleri ver 
            rb.useGravity = false;
            kure.AddComponent<CollisionScript>();


            MeshRenderer mesh = kure.GetComponent<MeshRenderer>(); // MeshRenderer ozellikleri ver
            mesh.material.color = UnityEngine.Random.ColorHSV(); // Random color ver

            kure.name = ("kure " + (i + 1));
            kure.transform.position = new Vector3(x, y, z);
        }



    }


    // Update is called once per frame
    void Update()
    {
        

        
    }
}
