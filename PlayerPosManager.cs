using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosManager : MonoBehaviour {

	public GameObject[] PlayerPos;
	public GameObject Player;
	public GameObject playerMain;

	void Awake()
	{
		playerMain.transform.rotation = PlayerPos [DataCentre.CurrentLevel].transform.localRotation;
	}

	// Use this for initialization
	void Start () {
		Player.transform.position = PlayerPos [DataCentre.CurrentLevel].transform.position;

		}

}
