using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backbtn : MonoBehaviour {


     public GameObject panela;
	 public GameObject panela_menu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void backbt(){
		panela.SetActive(false);
		panela_menu.SetActive(true);
	}
}
