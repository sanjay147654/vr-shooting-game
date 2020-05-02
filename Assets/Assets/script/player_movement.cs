using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour {
	public Rigidbody rb;
	public int force = 100;
	public Joystick joystick;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w"))
		{
			rb.AddRelativeForce(0,0,force*Time.deltaTime);
			Debug.Log("w");
		}
		if (Input.GetKey("a"))
		{
			rb.AddRelativeForce(-force * Time.deltaTime, 0, 0);
			Debug.Log("z");
		}
		if (Input.GetKey("d"))
		{
			rb.AddRelativeForce(force * Time.deltaTime, 0, 0);
			Debug.Log("z");
		}
		if (Input.GetKey("z"))
		{
			rb.AddRelativeForce(0, 0, -force * Time.deltaTime);
			Debug.Log("z");
		}

		//joystick
		rb.AddRelativeForce(joystick.Horizontal * force * Time.deltaTime, 0, joystick.Vertical * force * Time.deltaTime);
		
  rb.AddRelativeForce(Input.GetAxis("Horizontal") * force * Time.deltaTime, 0, Input.GetAxis("Vertical") * force * Time.deltaTime);

		

	}
}
