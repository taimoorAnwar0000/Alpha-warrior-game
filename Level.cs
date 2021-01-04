using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : GameController {


	public void OnEnable(){
		// Start the Ass Hole Level

	}
	void OnDisable(){
	}
	// Override Methods Of GameContrller
	public override void OnLevelStart ()
	{
		base.OnLevelStart ();
	
	}
	public override void OnLevelComplete ()
	{
		base.OnLevelComplete ();
	}
	public override void OnLevelFailed ()
	{
		base.OnLevelFailed ();
	}
	public override void OnLevelPaused ()
	{
		base.OnLevelPaused ();
	}
	public override void OnLevelRestart ()
	{
		base.OnLevelRestart ();
	}
	public override void OnLevelResume ()
	{
		base.OnLevelResume ();
	}
	public override void OnLevelRevive ()
	{
		base.OnLevelRevive ();
	}
}
