﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragonlLook : MonoBehaviour {

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
}
