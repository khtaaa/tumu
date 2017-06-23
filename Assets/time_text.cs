using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time_text : MonoBehaviour {
	public static float time;
	public GameObject button;
	public GameObject text;
	public GameObject height_text;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		button.SetActive (false);
		height_text.GetComponent<Text> ().enabled = false;
		text.GetComponent<Text> ().enabled = false;
		time = 60;
		GetComponent<Text> ().text =""+(int)time;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space))
			time -= 1;

		if (time > 0)
			player.ok = true;
		time -= Time.deltaTime;
		GetComponent<Text> ().text =""+(int)time;
		if (time <= 0) {
			player.ok = false;
			time = 0;
			Time.timeScale = 0;
			button.SetActive (true);
			text.GetComponent<Text> ().enabled = true;
			height_text.GetComponent<Text> ().enabled = true;
		}
	}
}
