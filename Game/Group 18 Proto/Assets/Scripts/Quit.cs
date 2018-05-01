using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour {

    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();
    }


    public void AQuit()
    {
        Application.Quit();
    }
}
