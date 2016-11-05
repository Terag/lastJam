﻿using UnityEngine;
using System.Collections;

public class ChangingTextureOnActivate : DefaultBlock {

    [SerializeField]
    private Sprite sprite1_whenActivated;

    [SerializeField]
    private Sprite sprite2_whenDesactivated;

    private bool isActive;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public override void activate() {
        if (!isActive)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprite1_whenActivated;
        }
    }

    public override void desactivate()
    {
        if(isActive)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprite2_whenDesactivated;
        }
    }

    public override void changeState()
    {
        if (isActive)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprite2_whenDesactivated;
        } else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprite1_whenActivated;
        }
    }

    public override void activateOnWalk()
    {
        changeState();
    }
}
