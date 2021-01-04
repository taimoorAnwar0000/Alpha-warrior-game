using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMUSIC : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this.gameObject);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Time.timeScale == 0 || DataCentre.MUSIC == false) {
			GetComponent<AudioSource> ().enabled = false;
		} else {
			if (DataCentre.MUSIC) 
			{
				GetComponent<AudioSource> ().enabled = true;
				if (!GetComponent<AudioSource> ().isPlaying) {
					GetComponent<AudioSource> ().Play ();
				}
			}

		}
	}
}
