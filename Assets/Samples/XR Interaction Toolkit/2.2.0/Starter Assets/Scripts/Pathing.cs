using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathing : MonoBehaviour
{
	public List<GameObject> waypoints;
	public float speed = 2;
	int index = 0;
	public bool hit = false;
	void Start()
	{
	}

	private void Update()
	{
		if(hit)
		{
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
