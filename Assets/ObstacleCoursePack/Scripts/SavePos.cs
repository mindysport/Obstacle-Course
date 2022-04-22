using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePos : MonoBehaviour
{
	public Transform checkPoint;

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			col.gameObject.GetComponent<CharacterControls>().checkPoint = checkPoint.position;
		}
	}
	void Trigger()
	{
		// Tell the animation controller about our 
		// recent triggering
		GetComponent<Animator>().SetTrigger("Triggered");
	}
}
