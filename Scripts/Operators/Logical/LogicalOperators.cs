using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperators : MonoBehaviour
{

	public bool LightsOn;
	public bool CarArrived;
	
	
	// Update is called once per frame
	void Update () {
		
		if (LightsOn && CarArrived)
		{
			print("Lights On, Car Arrived.");
		}
		
		if (LightsOn || CarArrived)
		{
			print("Lights On or Car Arrived.");
		}
	}
}
