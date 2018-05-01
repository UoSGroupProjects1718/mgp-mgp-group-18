using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class Winner : MonoBehaviour
{

    public BoxCollider2D WinnersBox;
    public SpriteRenderer Win;
    public SpriteRenderer Lose;
    public bool Player2;
    public bool result;
    public bool isWinner;


    // Use this for initialization
    void Start()
    {
        Win.enabled = false;
        Lose.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Player2 = (GameObject.Find("Player2").GetComponent<Player_2>().IsWinner);
    }
    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Main_Menu");
    }
    public void OnTriggerEnter2D(Collider2D WinnersBox)
    {
        if (WinnersBox.gameObject.tag == "Ground")
        {
            if (Player2 == true)
            {
                Lose.enabled = true;
                isWinner = false;
            }
            else
            {
                Win.enabled = true;
                result = true;
                isWinner = false;
            }
            if (isWinner == false)
            {
                StartCoroutine(EndGame());
                
            }
        }
    }
}