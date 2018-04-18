using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour {

    public Sprite IceBlock, WaterBlock, FireBlock, GrassBlock, MudBlock, StoneBlock;
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
                this.GetComponent<SpriteRenderer>().sprite = GrassBlock;
            }
        }
        if (CurrentBlock == MudBlock)
        {
            if (col.gameObject.tag == "WaterBlock")
            {
                this.GetComponent<SpriteRenderer>().sprite = GrassBlock;
            }
            if (col.gameObject.tag == "FireBlock")
            {
                this.GetComponent<SpriteRenderer>().sprite = StoneBlock;
            }
        }
        if (CurrentBlock == FireBlock)
        {
            if (col.gameObject.tag == "WaterBlock")
            {
                Destroy(gameObject);
            }
            if (col.gameObject.tag == "Grass")
            {
                this.GetComponent<SpriteRenderer>().sprite = MudBlock;
            }
        }
        if (CurrentBlock == IceBlock)
        {
            if (col.gameObject.tag == "FireBlock")
            {
                Destroy(gameObject);
            }
        }
    
    }
}
