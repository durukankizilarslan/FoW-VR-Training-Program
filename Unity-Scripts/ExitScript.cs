using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Baslat()
    {
        SceneManager.LoadScene(1);
    }

    public void Cikis()
    {
        Application.Quit();
    }

    public void OyunIciCikis()
    {
        SceneManager.LoadScene(0);
    }
}
