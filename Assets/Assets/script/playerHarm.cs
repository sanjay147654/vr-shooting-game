using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHarm : MonoBehaviour {

	public Text life;
	public int lifeNum = 200;

	void Start()
	{
		
	}

	// Use this for initialization
	//coliision
	void OnCollisionEnter(Collision collisionInfo)
	{
		//Destroy(prefab);
		if (collisionInfo.collider.name == "prefab(Clone)" || collisionInfo.collider.name == "alien1Obj" ||  collisionInfo.collider.name == "alien2Obj" || collisionInfo.collider.name == "demon1Obj" || collisionInfo.collider.name == "demon2Obj")
		{
			lifeNum--;
		}
		


		Debug.Log(collisionInfo.collider.name);
		Debug.Log(lifeNum);
		life.text = lifeNum.ToString();
	}

}
