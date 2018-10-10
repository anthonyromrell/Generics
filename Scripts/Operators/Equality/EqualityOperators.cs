using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EqualityOperators : MonoBehaviour
{

	public float A;
	public float B;
	public float C;
	
	// Update is called once per frame
	void Update () {
		
		if (A == B)
		{
			print("A is equal to B");
		}

		if (A >= B)
		{
			print("A is greater than B.");
		}
		
		if (A <= B)
		{
			print("A is less than B.");
		}

		if (A != B)
		{
			print("A is not equal to B.");
		}
		
		
	}
}
