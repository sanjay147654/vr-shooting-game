using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dieDragonScript : MonoBehaviour {

	public int life = 30;
	public GameObject dragon;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (life < 1)
		{
			Destroy(dragon);
			PlayerPrefs.SetInt("kill", (PlayerPrefs.GetInt("kill") + 1));
		}
	}

	void OnCollisionEnter(Collision collisionInfo)
	{
		if (collisionInfo.collider.name == "heroPrefab(Clone)")
		{
			life--;
			Debug.Log(collisionInfo.collider.name);
		}

		if (life == 0)
		{
			Destroy(dragon);
			PlayerPrefs.SetInt("kill", (PlayerPrefs.GetInt("kill") + 1));
			
		}
	}
}
