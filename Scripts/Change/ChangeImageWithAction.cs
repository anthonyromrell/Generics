using Basics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ChangeImageWithAction : MonoBehaviour
{
	public Image Bar;
	public GameAction UpdateAction;
	public UnityEvent OnLowBar;

	private void Start()
	{
		UpdateAction.Raise = Call;
	}

	private void Call(object value)
	{
		var newValue = (float) value;
		Bar.fillAmount += newValue;
		if (Bar.fillAmount <= 0)
		{
			OnLowBar.Invoke();
		}
	}
}