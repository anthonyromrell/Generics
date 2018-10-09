using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehaviours : MonoBehaviour {
	
	private void Awake()
	{
		print("Awake");
	}

	// Use this for initialization
	void Start () {
		print("Start");
	}
	
	// Update is called once per frame
	void Update () {
		print("Update");
	}

	private void OnMouseDown()
	{
		print("MouseDown");
	}
	
	private void OnMouseUp()
	{
		print("MouseUp");
	}

	private void OnEnable()
	{
		print("Enabled");
	}
}
