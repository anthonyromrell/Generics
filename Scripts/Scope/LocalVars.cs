using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalVars : MonoBehaviour
{
	string name;

	public void Call()
	{
		name = "Bob";
		print(name);
	}

	public void Call(string newName)
	{
		print(newName);
		print(name);
	}

}