using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayerWeapon : MonoBehaviour {

	public GameObject[] weapons;


	void Start()
	{
		DataCentre.Load ();
		Debug.Log ("Equiped"+DataCentre.equipedGun);

		WeaponSettings ();
	}

	void OnEnable()
	{
		WeaponSettings ();
	}

	void WeaponSettings () 
	{
		if (DataCentre.equipedGun == 0)
		{
			weapons [0].GetComponent<WeaponBehavior> ().haveWeapon = true;
		}
		else if (DataCentre.equipedGun == 1)
		{
			weapons [1].GetComponent<WeaponBehavior> ().haveWeapon = true;
		}
		else if (DataCentre.equipedGun == 2)
		{
			weapons [2].GetComponent<WeaponBehavior> ().haveWeapon = true;
		}
		else if (DataCentre.equipedGun == 3)
		{
			weapons [3].GetComponent<WeaponBehavior> ().haveWeapon = true;
		}
		else if (DataCentre.equipedGun == 4)
		{
			weapons [4].GetComponent<WeaponBehavior> ().haveWeapon = true;
		}
			
	}

	// Update is called once per frame
	void Update () {
		
	}
}
