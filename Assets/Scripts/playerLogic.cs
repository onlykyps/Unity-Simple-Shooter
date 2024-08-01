using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerLogic : MonoBehaviour {

	public GameObject projectile;
	public float playerSpeed = 1.0f;
	public float maxPlayerDistance = 29;
	public float projectileCollisionOffset = 4.0f;


	public float shootingSpeed = 0.5f;
	public bool isShooting = true; 

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (projectileShootTimer ());
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		playerMovement ();
		
	}

	void playerMovement()
	{
		if (Input.GetKey (KeyCode.A) && transform.position.x >= -maxPlayerDistance) 
		{
			transform.Translate (-playerSpeed,0,0);
						
		}

		if (Input.GetKey (KeyCode.D) && transform.position.x <= maxPlayerDistance) 
		{
			transform.Translate (playerSpeed,0,0);

		}

		if (Input.GetKey (KeyCode.W)) 
		{
			transform.Translate (0,playerSpeed,0);

		}

		if (Input.GetKey (KeyCode.S)) 
		{
			transform.Translate (0,-playerSpeed,0);

		}
	}

	IEnumerator projectileShootTimer()
	{
		while (isShooting == true) 
		{
			spawnProjectile ();
			yield return new WaitForSeconds (shootingSpeed);
		}
	}

	void spawnProjectile()
	{
		Instantiate (projectile, new Vector3(transform.position.x, transform.position.y+projectileCollisionOffset,0), Quaternion.identity);
	}

	void OnCollisionEnter2D(Collision2D tempCollision)
	{
		if (tempCollision.gameObject.tag == "Collision") 
		{
			SceneManager.LoadScene ("Scene_1");
		}
	}

}
