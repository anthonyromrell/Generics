using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddingForce : MonoBehaviour
{
	private Rigidbody rg;

	public Vector3 Force = Vector3.right;
	public float Power = 100;
	// Use this for initialization
	void Start ()
	{
		rg = GetComponent<Rigidbody>();
		rg.AddForce(Force*Power);
	}
	
}
