﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileLogic : MonoBehaviour {

	public float transformSpeed = 0.5f;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		moveTransformToTop ();
		
	}


	void moveTransformToTop()
	{
		transform.Translate (0, transformSpeed, 0);
	}

}
