using UnityEngine;
using UnityEngine.Events;

public class LightAction : MonoBehaviour
{
	public UnityAction LightSwitch;

	public UnityEvent OnEvent;
	public UnityEvent OffEvent;
	public UnityEvent ClickEvent;

	private void Start()
	{
		LightSwitch += LightOn;
		LightSwitch += PlaySound;
	}

	private void OnMouseDown()
	{
		LightSwitch();
	}

	private void LightOn()
	{
		OnEvent.Invoke();
		LightSwitch -= LightOn;
		LightSwitch += LightOff;
	}

	private void LightOff()
	{
		OffEvent.Invoke();
		LightSwitch -= LightOff;
		LightSwitch += LightOn;
	}

	private void PlaySound()
	{
		ClickEvent.Invoke();
	}
}
