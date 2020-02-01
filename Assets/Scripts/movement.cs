using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
	
	public float dirX, moveSpeed = 3f;
	bool moveRight = true;
	public float leftXpos = 22f;
	public float RightXpos = 10f;

	// Update is called once per frame
	void Update () {
		if (transform.position.x > leftXpos)
			moveRight = false;
		if (transform.position.x < RightXpos)
			moveRight = true;

		if (moveRight)
			transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
		else
			transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
	}
}
