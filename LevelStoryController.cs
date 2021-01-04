using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStoryController : MonoBehaviour {
	/*
	 * Parent Class Of Story Base Levels
	 * 
	 */
	public bool Next = false;
	public void StartStory(){
		StartCoroutine (TaskList ());
	}
	public virtual void NextTask(){
		Next = true;
	}
	public virtual IEnumerator TaskList(){
		// Simle Task Contorller baby
		yield return new WaitForSeconds(0.1f);

	}
}
