using UnityEngine;

[CreateAssetMenu(fileName = "TransformVariable")]
public class TransformVariable : ScriptableObject
{
	private Transform value;

	public Transform Value
	{
		get { return value; }
		set { this.value = value; }
	}
}
