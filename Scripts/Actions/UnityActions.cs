using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityActions : MonoBehaviour
{

	public UnityAction UAction;

	public UnityEvent OnEvent;

	public UnityEvent OffEvent;
	// Use this for initialization
	void Start ()
	{
		UAction = On;
	}

	private void OnMouseDown()
	{
		if (UAction != null) 
			UAction();
	}

	// Update is called once per frame
	void On () {
		OnEvent.Invoke();
		print("On");
		UAction = Off;
	}

	void Off()
	{
		OffEvent.Invoke();
		print("Off");
		UAction = On;
	}
}
