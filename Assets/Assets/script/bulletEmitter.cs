using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletEmitter : MonoBehaviour {
	public GameObject prefab;
	public int num = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (num!=5)
		{
			num++;
		}
		else
		{
			fire();
			num = 0;
		}

		
	}


	//custom
	private void fire()
	{
		GameObject obj= Instantiate(prefab, transform.position,transform.rotation);

		Destroy(obj,1);
		

	}
}
