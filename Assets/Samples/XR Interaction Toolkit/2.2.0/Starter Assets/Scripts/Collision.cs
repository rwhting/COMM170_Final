using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
	public bool hit = false;
	void OnTriggerEnter(Collider col)
	{
		if (col.name == "RightHand (Teleport Locomotion)")
		{
			print("Another object has entered the trigger");
			hit = true;
		}
		
	}
}
