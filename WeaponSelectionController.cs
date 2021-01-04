using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSelectionController : IMenuController {

//	public GameObject[] weapons;
	//public int[] weaponPrice;
	public int WeaponPurchased;
	public GameObject[] buyButtons;

	public GameObject[] gunproperties;

	public GameObject equiped;
	public GameObject playButton;

	public GameObject _lock;
	public GameObject priceLabel;
	public Text totalCoins;
	public Text totalScore;

	public int selectedWeapon;

//	public SoldierMainMenu soliderMainMenu;


	public GameObject popup;


	void OnEnable()
	{

		DataCentre.Load ();
		popup.SetActive (false);
//	
			DisableAll ();
			selectedWeapon = DataCentre.SelectedWeaponMenu;
//			weapons [DataCentre.SelectedWeaponMenu].SetActive (true);
			gunproperties [DataCentre.SelectedWeaponMenu].SetActive (true);
			buyButtons [DataCentre.SelectedWeaponMenu].SetActive (true);
			_lock.SetActive (!DataCentre.UnlockWeapon[DataCentre.SelectedWeaponMenu]);
			priceLabel.GetComponent<Text> ().text = DataCentre.WeaponPrice [DataCentre.SelectedWeaponMenu].ToString ();
			ManageBuyButton ();
//		}

		ManageBuyButton ();
		totalCoins.text = DataCentre.Coins.ToString ();
		totalScore.text = DataCentre.SCORE.ToString ();


		if (DataCentre.NOADS == 0) {
			//AdManager.Instance.ShowBanner ();
		}


		if (DataCentre.SelectedWeaponMenu == DataCentre.equipedGun) {
			equiped.SetActive (true);
		} else {
			equiped.SetActive (false);
		}

		Screen.sleepTimeout = SleepTimeout.NeverSleep;



	}

	void Start()
	{
		Time.timeScale = 1f;
//		
	}

	void Update()
	{
		Time.timeScale = 1f;

	}

	private void DisableAll(){
		for(int i=0;i<5;i++){
//			weapons [i].SetActive (false);
			gunproperties [i].SetActive (false);
			buyButtons [i].SetActive (false);

		}
	}
	public void Next()
	{
		DisableAll ();
		DataCentre.SelectedWeaponMenu = Mathf.Clamp (DataCentre.SelectedWeaponMenu + 1, 0, 5);
		if (DataCentre.SelectedWeaponMenu > 4) 
		{
			DataCentre.SelectedWeaponMenu = 0;
		}
//		weapons [DataCentre.SelectedWeaponMenu].SetActive (true);
		gunproperties [DataCentre.SelectedWeaponMenu].SetActive (true);
		priceLabel.GetComponent<Text> ().text = DataCentre.WeaponPrice [DataCentre.SelectedWeaponMenu].ToString ();

		ManageBuyButton ();

		selectedWeapon = DataCentre.SelectedWeaponMenu;

		if (DataCentre.SelectedWeaponMenu == DataCentre.equipedGun) {
			equiped.SetActive (true);
		} else {
			equiped.SetActive (false);
		}
//		weapons[DataCentre.SelectedWeaponMenu].GetComponent<Animation> ().Play ("Reload");
		DataCentre.Save ();
	}

	public void Previous()
	{
		DisableAll ();
		DataCentre.SelectedWeaponMenu = Mathf.Clamp (DataCentre.SelectedWeaponMenu - 1, -1, 4);
		if (DataCentre.SelectedWeaponMenu < 0) 
		{
			DataCentre.SelectedWeaponMenu = 4;
		}
//		weapons [DataCentre.SelectedWeaponMenu].SetActive (true);
		gunproperties [DataCentre.SelectedWeaponMenu].SetActive (true);
		priceLabel.GetComponent<Text> ().text = DataCentre.WeaponPrice [DataCentre.SelectedWeaponMenu].ToString ();
		ManageBuyButton ();
		selectedWeapon = DataCentre.SelectedWeaponMenu;

		if (DataCentre.SelectedWeaponMenu == DataCentre.equipedGun) {
			equiped.SetActive (true);
		} else {
			equiped.SetActive (false);
		}
//		weapons[DataCentre.SelectedWeaponMenu].GetComponent<Animation> ().Play ("Reload");
		DataCentre.Save ();
	}


	public void ManageBuyButton()
	{
		if (DataCentre.UnlockWeapon [DataCentre.SelectedWeaponMenu]) 
		{
			buyButtons [DataCentre.SelectedWeaponMenu].SetActive (false);
			_lock.SetActive (false);
			playButton.SetActive (true);
		}
		else
		{
			buyButtons [DataCentre.SelectedWeaponMenu].SetActive (true);
			_lock.SetActive (true);
			playButton.SetActive (false);
		}
	}


	public void BuyWeapon(int weaponID)
	{
		if (DataCentre.Coins >= DataCentre.WeaponPrice [weaponID]) {
			DataCentre.Coins -= DataCentre.WeaponPrice [weaponID];
			DataCentre.UnlockWeapon [weaponID] = true;
			totalCoins.text = DataCentre.Coins.ToString ();
			buyButtons [weaponID].SetActive (false);
			buyButtons [0].SetActive (true);
			_lock.SetActive (false);

			DataCentre.Save ();
		} else {
			popup.SetActive (true);
		}
	}

	public void OkayFromPopup()
	{
		popup.SetActive (false);
	}


	public void PlayFromWeapon()
	{
		DataCentre.equipedGun = DataCentre.SelectedWeaponMenu;
		DataCentre.Save ();
	}




}
