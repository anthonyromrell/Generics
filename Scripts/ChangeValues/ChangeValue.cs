﻿using UnityEngine;

//Made By Anthony Romrell
[CreateAssetMenu]
public class ChangeValue : ScriptableObject
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