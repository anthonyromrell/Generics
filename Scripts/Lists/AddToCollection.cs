using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Objects/Add To Collection")]
public class AddToCollection : ScriptableObject
{
	public ScriptableObjectCollection Collection;
	
	public void Call(ScriptableObject obj)
	{
		Collection.ObjectList.Add(obj);
	}	
}