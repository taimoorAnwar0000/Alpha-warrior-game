using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScreen : IMenuController {

	public MenuManager menuMan;
//	public float progressOP;
//	public Image loadingBar;

	// Use this for initialization
	void Start () {
		
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
	
	// Update is called once per frame
	void Update () {
//		progressOP = menuMan.op.progress;
//		loadingBar.fillAmount = progressOP;
	}
}
