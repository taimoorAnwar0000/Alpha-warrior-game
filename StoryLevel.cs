using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryLevel : Level {

	//Every Level Has Some Unique Task to Do
	private LevelStoryController storyController;
	public void OnEnable(){
		// Start the Ass Hole Level
		storyController = this.GetComponent<LevelStoryController>();
	}
	void OnDisable(){
	}
	// Override Methods Of GameContrller
	public override void OnLevelStart ()
	{
		base.OnLevelStart ();

		if (storyController != null) {
			storyController.StartStory ();
		}
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

	public override void OnTaskComplete ()
	{
		base.OnTaskComplete ();
		storyController.NextTask ();
	}
}
