using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonLevel : MonoBehaviour {

    public void newGameBtn(string newGameLevel)
    {
        SceneManager.LoadScene("Prototype");
    }
    public void InstructionsBtn(string newGameLevel)
    {
        SceneManager.LoadScene("Instructions");
    }

    public void ReturnBtn(string newGameLevel)
    {
        SceneManager.LoadScene("Main_Menu");
    }
    public void ExitGameButton()
    {
        Application.Quit();
    }
}
