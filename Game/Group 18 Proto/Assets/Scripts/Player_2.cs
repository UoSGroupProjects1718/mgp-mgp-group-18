using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2 : MonoBehaviour {

    public BoxCollider2D WinnersBox1;
    public bool IsWinner;
    public SpriteRenderer Win;
    public SpriteRenderer Lose;
    public bool Player1;

	// Use this for initialization
	void Start () {
        Win.enabled = false;
        Lose.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        Player1 = (GameObject.Find("Player").GetComponent<Winner>().result);
    }

    public void OnTriggerEnter2D(Collider2D WinnersBox)
    {
        if (WinnersBox.gameObject.tag == "Ground")
        {
            if (Player1 == true)
            {
                Lose.enabled = true;
            }
            else
            {
                Win.enabled = true;
                IsWinner = true;
            }
        }
    }
}
