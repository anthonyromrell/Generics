using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CollectionList : ScriptableObject
{
	public List<GameObject> Diamonds;
	 
	public void AddDiamond(GameObject diamond)
	{
		Diamonds.Add(diamond);
	}
}
