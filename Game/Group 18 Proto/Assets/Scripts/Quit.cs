using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour {

    public Button QuitButton;

    void Start()
    {
        Button btn = QuitButton.GetComponent<Button>();
        btn.onClick.AddListener(AQuit);
    }
    void AQuit()
    {
        Application.Quit();
    }
}
