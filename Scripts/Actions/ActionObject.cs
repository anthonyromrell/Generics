using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Actions/ActionObject")]
public class ActionObject : ScriptableObject
{
	public UnityAction Raise;
}
