using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Objects/ScriptableObject Collection")]
public class ScriptableObjectCollection : ScriptableObject
{
	public List<ScriptableObject> ObjectList;
}