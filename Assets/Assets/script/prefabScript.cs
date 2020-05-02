using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class prefabScript : MonoBehaviour {
	public float force = 3000.0f;
	public Rigidbody prefab;
	public Text life;
	public int lifeNum = 200;

	

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt("lifeNum", lifeNum);
	}
	
	// Update is called once per frame
	void Update () {
		prefab.AddRelativeForce(force * Time.deltaTime, 0,0);
	}

	
	

	// custom function
	
}
