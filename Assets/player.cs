using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
	public float move;
	public float rote;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		rote = Input.GetAxis ("Vertical");
		move = Input.GetAxis("Horizontal");

		transform.Rotate (0f, 0f, rote * 1.5f);
		transform.position+=new Vector3 (move*0.1f, 0f, 0f);

		if (transform.position.x < -6)
			transform.position = new Vector3 (-6f, -2f, 0f);

		if (transform.position.x > -3)
			transform.position = new Vector3 (-3f, -2f, 0f);
	}
}
