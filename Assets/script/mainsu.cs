using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainsu : MonoBehaviour {
	public float pos;

	// Use this for initialization
	void Start () {
		pos = transform.position.y;
		Destroy (gameObject, 1.5f);
	}
	
	// Update is called once per frame
	void Update () {
		pos += 0.1f;
		transform.position=new Vector3(transform.position.x,pos,transform.position.z);
	}
}
