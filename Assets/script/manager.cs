using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour {
	public static string difficulty;
	public GameObject FoundationA;
	public GameObject FoundationB;
	public GameObject FoundationC;

	// Use this for initialization
	void Start () {
		if(difficulty=="normal")
		{
			Instantiate (FoundationA);
		}

		if(difficulty=="easy")
		{
			Instantiate (FoundationB);
		}
		if(difficulty=="hard")
		{
			Instantiate (FoundationC);
		}



	}
	
	// Update is called once per frame
	void Update () {

			
	}
}
