using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class height_text : MonoBehaviour {
	public static float height;
	public GameObject foundation;
	public float rust_height;

	// Use this for initialization
	void Start () {
		foundation = null;
		height = -5;
		GetComponent<Text> ().text ="";
	}
	
	// Update is called once per frame
	void Update () {
		Calculation ();
	}

	public void Calculation()
	{
		rust_height = height - foundation.transform.position.y;
		rust_height = rust_height * 10;
		rust_height = Mathf.Floor (rust_height);
		rust_height = rust_height /10;
		GetComponent<Text> ().text ="record:"+rust_height+"M";
	}
}
