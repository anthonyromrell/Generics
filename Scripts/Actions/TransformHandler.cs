using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformHandler : MonoBehaviour
{

	public TransformAction Get;
	private Vector3 temp;
	
	// Use this for initialization
	void Start ()
	{
		Get.SendTransform += Call;
		temp = transform.position;
	}
	
	// Update is called once per frame
	void Call (Transform t)
	{
		temp = t.position;
	}

	private void Update()
	{
		transform.position = Vector3.Lerp(transform.position, temp, 0.1f);
	}
}
