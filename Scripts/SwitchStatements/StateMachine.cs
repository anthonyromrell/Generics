using UnityEngine.Events;
using UnityEngine;

[CreateAssetMenu]
public class StateMachine : ScriptableObject {

	public GameStates.States GameState;
	public UnityEvent Starting, Loading, Playing, Ending, Dying;
	
	// Update is called once per frame
	public void Run () {
		
		switch (GameState)
		{
			case GameStates.States.Starting:
				Starting.Invoke();
				break;
			
			case GameStates.States.Loading:
				//print("We are loading the Game");
				break;
			
			case GameStates.States.Playing:
				//print("We are playing the Game");
				break;
			
			case GameStates.States.Ending:
				//print("We are ending the Game");
				break;
		}
	}
	
}
