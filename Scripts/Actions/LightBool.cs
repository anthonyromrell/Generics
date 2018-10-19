using Basics;
using UnityEngine;

public class LightBool : MonoBehaviour
{
	public bool LightSwitch = true;

	private void OnMouseDown()
	{
		if (LightSwitch)
		{
			Debug.Log("On");
			Debug.Log("I Love Cats");
			LightSwitch = false;
		}
		else
		{
			Debug.Log("Off");
			Debug.Log("I Love Cats");
			LightSwitch = true;
		}
	}
}