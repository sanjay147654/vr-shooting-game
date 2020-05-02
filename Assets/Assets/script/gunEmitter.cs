using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunEmitter : MonoBehaviour {

	// Use this for initialization
	public GameObject prefab;
	public int num = 0;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		
			if (num != 3)
			{
				num++;
			}
			else
			{

			if (Input.GetKey(KeyCode.Return))
			{
				fire();
				num = 0;

			}


			}
		

	}


	//custom
	private void fire()
	{
		GameObject obj = Instantiate(prefab, transform.position, transform.rotation);

		Destroy(obj, 1.5f);


	}
}
