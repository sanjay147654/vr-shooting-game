using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dieScript : MonoBehaviour {
	public int life = 10;
	public GameObject drone;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collisionInfo)
	{
		if (collisionInfo.collider.name=="heroPrefab(Clone)")
		{
			
			life--;
			Debug.Log(collisionInfo.collider.name);
		}

		if (life == 0)
		{
			Destroy(drone);
			PlayerPrefs.SetInt("kill", (PlayerPrefs.GetInt("kill") + 1));
			
		}
	}

	//custom script

}
