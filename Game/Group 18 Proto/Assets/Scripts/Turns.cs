using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turns : MonoBehaviour {

    public bool Player1Turn;
    public BoxCollider2D P1Box;
    public BoxCollider2D P2Box;
    private bool Turn;

	// Use this for initialization
	void Start () {
        Player1Turn = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
