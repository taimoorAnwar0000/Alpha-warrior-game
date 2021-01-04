using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

	public NPCRegistry npcRegistry;
	public HealthText healthText;

	public HudMenuController hudMenu;
	public GameObject completeController;
	public GameObject failController;

	// intssss
	public int abComplete;
	public int abFail;


	public GameObject minimap;

	public int enemiesKilled;
	public int totalEnemies;

	public GameObject healthKit;

	// Use this for initialization
	void Start () {
		enemiesKilled = 0;


		npcRegistry = GameObject.FindObjectOfType<NPCRegistry> ();
		healthText = GameObject.FindObjectOfType<HealthText> ();
		//hudMenu = GameObject.FindObjectOfType<HudMenuController> ();
		abComplete = 0;
		abFail = 0;

		totalEnemies = GameObject.FindObjectsOfType<AI> ().Length;

	}
	
	// Update is called once per frame
	void Update () {

		if (npcRegistry.Npcs.Count == 0 && healthText.healthGui > 0) {
			if (abComplete == 0) {
				hudMenu = GameObject.FindObjectOfType<HudMenuController> ();
				abComplete = 1;

				// level complete database setting
				if (DataCentre.BaseID == 1) {
					if (DataCentre.CurrentLevel < 9) {
						DataCentre.UnlockLevel1 [Mathf.Clamp (DataCentre.CurrentLevel + 1, 0, DataCentre.UnlockLevel1.Length)] = true;
					}
					if (DataCentre.CurrentLevel == 9) 
					{
						DataCentre.UnlockBase [1] = true;
					}
				}

				if (DataCentre.BaseID == 2) {
					if (DataCentre.CurrentLevel < 9) {
						DataCentre.UnlockLevel2 [Mathf.Clamp (DataCentre.CurrentLevel + 1, 0, DataCentre.UnlockLevel2.Length)] = true;
					}
					if (DataCentre.CurrentLevel == 9) 
					{
//						DataCentre.UnlockBase [2] = true;
					}
				}

				if (DataCentre.BaseID == 3) {
					if (DataCentre.CurrentLevel < 9) {
						DataCentre.UnlockLevel3 [Mathf.Clamp (DataCentre.CurrentLevel + 1, 0, DataCentre.UnlockLevel3.Length)] = true;
					}
				}


				DataCentre.Save ();


				Debug.Log ("Level Complete");
				hudMenu.OnLevelComplete ();

				DataCentre.Save ();
				minimap.SetActive (false);
			}

		}


		if (npcRegistry.Npcs.Count > 0 && healthText.healthGui < 2) 
		{
			if (abFail == 0) 
			{
				abFail = 1;
				hudMenu = GameObject.FindObjectOfType<HudMenuController> ();
				Debug.Log ("Game Failed");
				hudMenu.OnLevelFailed ();
				minimap.SetActive (false);
			}
		}



		if (DataCentre.SCORE == 25) {
		//	GPGManager.Instance.UnlockAchievment01 ();
		}
		if (DataCentre.SCORE == 50) {
		//	GPGManager.Instance.UnlockAchievment02 ();
		}
		if (DataCentre.SCORE == 100) {
		//	GPGManager.Instance.UnlockAchievment03 ();
		}
		if (DataCentre.SCORE == 2) {
		//	GPGManager.Instance.UnlockAchievment04 ();
		}
		if (DataCentre.SCORE == 10) {
		//	GPGManager.Instance.UnlockAchievment05 ();
		}
		if (DataCentre.SCORE == 60) {
		//	GPGManager.Instance.UnlockAchievment06 ();
		}


	}


}
