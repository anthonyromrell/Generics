using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

	IEnumerator Start () {
		yield return new WaitForSeconds(2);
		Destroy(gameObject);
	}

	private void OnCollisionStay(Collision other)
	{
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}
