using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alien2look : MonoBehaviour {

	public GameObject player;
	public Vector3 vect1;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		// Rotate the camera every frame so it keeps looking at the target
		transform.LookAt(player.transform);
		transform.Translate(vect1 * Time.deltaTime);


	}

	private void OnCollisionEnter(Collision collisionInfo)
	{
		if (collisionInfo.collider.name == "player")
		{
			vect1 = -vect1;
			Invoke("reset", 0.5f);
		}
	}

	//custom function
	private void reset()
	{
		vect1 = -vect1;
	}
}
