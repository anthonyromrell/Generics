using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignmentOperator : MonoBehaviour
{
	private SpriteRenderer sprite;
	
	// Use this for initialization
	void Start ()
	{
		sprite = GetComponent<SpriteRenderer>();
	}

	private void OnMouseDown()
	{
		sprite.color = Color.green;
	}
}
