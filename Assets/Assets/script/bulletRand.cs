using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletRand : MonoBehaviour {
	public GameObject prefab;
	public bool fireStatus=false;
	public int num = 0;
	// Use this for initialization
	void Start () {
		timeCount();
	}
	
	// Update is called once per frame
	void Update () {
		if (num != 5 )
		{
			num++;
		}
		else
		{
			if (fireStatus==true)
			{
				fire();
			}
			
			num = 0;
		}
	}

	private void timeCount()
	{
		
		if (Random.Range(1, 3)==2)
		{
			fireStatus = true;
		}
		else
		{
			fireStatus = false;
		}

		Invoke("timeCount",1);
	}

	private void fire()
	{
		GameObject obj = Instantiate(prefab, transform.position, transform.rotation);

		Destroy(obj, 1);
	}
}
