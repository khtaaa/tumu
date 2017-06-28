using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class title_button : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void normal()
	{
		Application.LoadLevel("game");
		manager.difficulty="normal";
	}

	public void hard()
	{
		Application.LoadLevel("game");
		manager.difficulty="hard";
	}

	public void easy()
	{
		Application.LoadLevel("game");
		manager.difficulty="easy";
	}

}
