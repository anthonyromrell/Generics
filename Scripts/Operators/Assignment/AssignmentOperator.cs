using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignmentOperator : MonoBehaviour
{
	private SpriteRenderer Sprite;
	
	// Use this for initialization
	void Start ()
	{
		Sprite = GetComponent<SpriteRenderer>();
	}

	private void OnMouseDown()
	{
		Sprite.color = Color.green;
	}
}
