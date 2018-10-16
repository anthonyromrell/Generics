using UnityEngine;

public class ParentObject : ScriptableObject
{
	public int Health = 100;
	protected float PowerLevel = 100;
	private string PlayerName = "Bob";
}


public class ChildObject : ParentObject
{
	void Update()
	{
		Health = 90;
		PowerLevel = 1000; 
	}
}

public class OutsideObject : MonoBehaviour
{
	public ParentObject Parent;

	void Update()
	{
		Parent.Health = 80;
	}
}