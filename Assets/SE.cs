using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class SE : MonoBehaviour {
	public AudioClip[] seLists;
	AudioSource source;

	void Start () {
		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void koukaon(int i)
	{
		source.PlayOneShot (null);//効果音停止
		source.PlayOneShot(seLists[i]);//効果音
		return;
	}

}
