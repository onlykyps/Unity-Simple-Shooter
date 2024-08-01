using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyTransform : MonoBehaviour {

	ScoreLogic addToScore;
	public GameObject particles;

	void Start () 
	{
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D transformCollision)
	{
		if(transformCollision.gameObject.tag == "Collision")
		{
			spawnParticles (transformCollision.transform.position);
			Destroy (transformCollision.gameObject);
			callScoreLogicScript ();
		}

	}

	void callScoreLogicScript()
	{
		addToScore = GameObject.FindGameObjectWithTag ("GUI").GetComponent<ScoreLogic> ();
		addToScore.addToScoreVoid ();
	}

	void spawnParticles(Vector2 tempPos)
	{
		Instantiate (particles, tempPos, Quaternion.identity);
	}

}
