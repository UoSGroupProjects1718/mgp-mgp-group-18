using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winner : MonoBehaviour
{

    public BoxCollider2D WinnersBox;
    public SpriteRenderer Win;
    public SpriteRenderer Lose;
    public bool Player2;
    public bool result;


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
    public void OnTriggerEnter2D(Collider2D WinnersBox)
    {
        if (WinnersBox.gameObject.tag == "Ground")
        {
            if (Player2 == true)
            {
                Lose.enabled = true;
            }
            else
            {
                Win.enabled = true;
                result = true;
            }
        }
    }
}