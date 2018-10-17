using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddiongExplosiveForce : MonoBehaviour
{
	public float Radius = 2;
	public float Force = 1000;
	private Rigidbody rg;
	// Use this for initialization
	void Start ()
	{
		rg = GetComponent<Rigidbody>();
		rg.AddExplosionForce(Force, transform.position, Radius);
	}

	private void OnCollisionEnter(Collision other)
	{
		other.gameObject.GetComponent<Rigidbody>().AddExplosionForce(Force, Vector3.forward, Radius);
	}
}
