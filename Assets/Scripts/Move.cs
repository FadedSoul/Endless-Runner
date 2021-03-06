﻿using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	
	public Transform target;
	public Transform startTarget;
	public float speed;
	
	void Update() {
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target.position, step);
		
		if (transform.position == target.position) {
			transform.position = startTarget.position;
		}

		if (speed < 10f) 
		{
			speed = 5f;
			//Debug.Log(speed);
		}
	}

}