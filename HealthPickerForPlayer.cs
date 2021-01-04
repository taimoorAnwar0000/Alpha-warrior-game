using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickerForPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "HeathKit") {
			GameObject.FindObjectOfType<HEalthManager> ().IncrementHealth ();
			GameObject.FindObjectOfType<HudMenuController> ().healthIncrementPopup.SetActive (true);
			Destroy (col.gameObject);
		}
		
	}
}
