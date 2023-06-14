using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
	public bool hit = false;
	public List<GameObject> waypoints;
	public float speed = 2;
	int index = 0;
	void OnTriggerEnter(Collider col)
	{
		if (col.name == "RightHand (Teleport Locomotion)" || col.name == "LeftHand (Smooth locomotion)")
		{
			print("Another object has entered the trigger");
			SceneManager.LoadScene("New Scene");
			Vector3 destination = waypoints[index].transform.position;
			Vector3 newPos = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
			transform.position = newPos;
		
			float distance = Vector3.Distance(transform.position, destination);
			if(distance <= 0.05)
			{
				index++;
			}
		}
		
	}
}
