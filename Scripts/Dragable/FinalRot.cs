using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalRot : MonoBehaviour {

	
	float speed = 10, max = 0, min = 90f, angle = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnMouseDrag () {
		
		// while button pressed, decrease the value by speed * Time.deltaTime
		angle = Input.GetAxis("Mouse X");
		angle = Mathf.Clamp(angle, min, max);
		transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, angle);
	}
}
