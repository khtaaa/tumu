using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {
	public GameObject[] obj;
	public float time;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;//秒を獲得

		if (time > 3) {
			time = 0;
			Instantiate (obj[(int)Random.Range(0,obj.Length)], new Vector3 (-5, 5, 0), Quaternion.identity);
		}
	}
}
