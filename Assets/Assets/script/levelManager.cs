using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelManager : MonoBehaviour {


	//public object
	public GameObject door1;
	public GameObject door2;
	public GameObject door3;

	//text game object
	public Text kill;


	public int doorH1=0;
	public int doorH2 = 0;
	public int doorH3 = 0;

	public Vector3 vect3;


	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt("kill", 0);
		
		
	}
	
	// Update is called once per frame
	void Update () {

		//call open door
		openDoor1();
		openDoor2();
		openDoor3();

		kill.text = "kill= " + PlayerPrefs.GetInt("kill").ToString();

		Debug.Log(UnityEngine.Input.GetJoystickNames());
	}



















	//custom function
	public void openDoor1()
	{
		if (doorH1<85 && PlayerPrefs.GetInt("kill")==3)
		{
			door1.transform.position= door1.transform.position+vect3;
			doorH1++;
		}
	}

	public void openDoor2()
	{
		if (doorH1 < 85 && PlayerPrefs.GetInt("kill") == 7)
		{
			door2.transform.position = door2.transform.position + vect3;
			doorH1++;
		}
	}

	public void openDoor3()
	{
		if (doorH1 < 85 && PlayerPrefs.GetInt("kill") == 8)
		{
			door3.transform.position = door3.transform.position + vect3;
			doorH1++;
		}
	}
}
