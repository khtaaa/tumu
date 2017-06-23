using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour {
	public GameObject del;
	public bool ok;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ( height_text.height < transform.position.y && ok==true)
		{
			height_text.height = transform.position.y;
		}
	}

	//オブジェクトが衝突したとき
	void OnCollisionEnter(Collision col) {
		
		if(col.gameObject.CompareTag("block"))
			ok = true;
		if (col.gameObject.CompareTag ("del")) {
			Instantiate (del, new Vector3( transform.position.x,-5f,0f), Quaternion.identity);
			Destroy (gameObject);
		}
	}

	//オブジェクトが離れた時
	void OnCollisionExit(Collision collision) {
		ok = false;
	}

	//オブジェクトが触れている間
	void OnCollisionStay(Collision collision) {
		ok = true;
	}
}
