using Basics;
using UnityEngine;

//Made By Anthony Romrell
[CreateAssetMenu(menuName = "Change/Float Value")]
public class ChangeFloatValue : ScriptableObject
{
	public FloatData Data;
	
	public void AddValue (FloatData obj)
	{
		Data.Value += obj.Value;
	}
	
	public void SubtractValue (FloatData obj)
	{
		Data.Value -= obj.Value;
	}
}