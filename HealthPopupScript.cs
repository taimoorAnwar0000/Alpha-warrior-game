using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPopupScript : MonoBehaviour {

	void OnEnable()
	{
		Invoke ("DisableThis", 3f);
	}

	void OnDisable()
	{
		
	}

	void DisableThis()
	{
		this.gameObject.SetActive (false);
	}

}
