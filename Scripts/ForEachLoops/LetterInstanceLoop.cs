using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterInstanceLoop : MonoBehaviour
{

	public GameObject[] Word;
	private Vector3 position;
	
	// Use this for initialization
	void Start () {
		foreach (var letter in Word)
		{
			position.x += 2.5f;
			Instantiate(letter, position, Quaternion.identity);
		}
	}
}