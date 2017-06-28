using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foundation : MonoBehaviour {
	public GameObject hight;

	// Use this for initialization
	void Start () {
		hight = GameObject.Find ("height_text");
		hight.GetComponent<height_text> ().foundation = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
