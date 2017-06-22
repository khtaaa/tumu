using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour {
	public GameObject del;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	//オブジェクトが衝突したとき
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.CompareTag ("del")) {
			Instantiate (del, new Vector3( transform.position.x,-5f,0f), Quaternion.identity);
			Destroy (gameObject);
		}
	}
}
