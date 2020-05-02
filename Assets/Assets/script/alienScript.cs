using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienScript : MonoBehaviour {
	public Rigidbody rbAlien1;
	public Rigidbody rbAlien2;
	public Rigidbody rbDemon1;
	public Rigidbody rbDemon2;

	public GameObject obAlien1;
	public GameObject obAlien2;
	public GameObject obDemon1;
	public GameObject obDemon2;

	public float force = 0.2f;

	



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (obAlien1!=null && obAlien1.activeInHierarchy)
		{
			rbAlien1.AddRelativeForce(0, 0, force, ForceMode.VelocityChange);
		}
		if (obAlien2 != null && obAlien2.activeInHierarchy)
		{
			rbAlien2.AddRelativeForce(0, 0, force, ForceMode.VelocityChange);
		}
		if (obDemon1 != null && obDemon1.activeInHierarchy)
		{
			rbDemon1.AddRelativeForce(0, 0, force, ForceMode.VelocityChange);
		}
		if (obDemon2 != null && obDemon2.activeInHierarchy)
		{
			rbDemon2.AddRelativeForce(0, 0, force, ForceMode.VelocityChange);
		}





	}
}
