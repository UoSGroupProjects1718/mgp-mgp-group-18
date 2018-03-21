using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour {

    public Sprite IceBlock, WaterBlock, FireBlock, GrassBlock, MudBlock;
    private Sprite CurrentBlock;

	// Use this for initialization
	void Start () {
        CurrentBlock = GetComponent<SpriteRenderer>().sprite;       
	}
	
	// Update is called once per frame
	void Update () 
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (CurrentBlock == WaterBlock)
        {
            if (col.gameObject.tag == "Ice")
            {
                this.GetComponent<SpriteRenderer>().sprite = IceBlock;
            }
            if (col.gameObject.tag == "MudBlock")
            {
                Destroy(gameObject);
            }
        }
        if (CurrentBlock == MudBlock)
        {
            if (col.gameObject.tag == "WaterBlock")
            {
                this.GetComponent<SpriteRenderer>().sprite = GrassBlock;
            }
        }
    
    }
}
