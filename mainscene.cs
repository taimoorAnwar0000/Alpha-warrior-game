using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainscene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		Invoke("mainload", 0.2f);
	}
	
	// Update is called once per frame
	void Update () {
		Time.timeScale = 1f;
	}
	
	void mainload(){
		Debug.Log("sad");
		 SceneManager.LoadScene("MainMenu");
	}
}
