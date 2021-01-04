using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit_btn : MonoBehaviour {


    public GameObject dilog_exit;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void exitbtn(){
		dilog_exit.gameObject.SetActive(true);
		Debug.Log("hey");
	}
	
	public void exitdilog(){
		dilog_exit.gameObject.SetActive(false);
	}
	
	public void quit_game(){
		
		 Application.Quit();
	}
}
