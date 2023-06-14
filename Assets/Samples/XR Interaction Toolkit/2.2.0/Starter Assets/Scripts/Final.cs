using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
	void OnTriggerEnter(Collider col)
	{
		if (col.name == "RightHand (Teleport Locomotion)" || col.name == "LeftHand (Smooth locomotion)")
		{
			SceneManager.LoadScene("Finale");
		}
		
	}
	
}
