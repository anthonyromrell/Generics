using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendTransform : MonoBehaviour {

	public GameAction Send;

	private void Start()
	{
		Send.Call(transform);
	}
}
