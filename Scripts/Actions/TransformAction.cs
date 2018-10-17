using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TransformAction : MonoBehaviour
{

	public UnityAction<Transform> SendTransform;

	private void OnMouseDown()
	{
		SendTransform(transform);
	}

}
