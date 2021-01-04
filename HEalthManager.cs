using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HEalthManager : MonoBehaviour {

	public int healthTotal;
	public GameObject healthbar;
	public GameObject healthText;
	public float healthValueForBar;

	private Text healthTextObj;
	private Image HealthImageObj;
	public HealthText healthTextGameObject;


	void OnEnable()
	{
		HealthImageObj = healthbar.GetComponent<Image> ();
		healthTextObj = healthText.GetComponent<Text> ();
	}

	// Use this for initialization
	void Start () 
	{
		if (!healthTextGameObject) 
		{
			healthTextGameObject = GameObject.FindObjectOfType<HealthText> ();
		}
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (!healthTextGameObject) 
		{
			healthTextGameObject = GameObject.FindObjectOfType<HealthText> ();
		}

		if (healthTextGameObject) 
		{
			healthTotal = (int)healthTextGameObject.healthGui;
			healthValueForBar = (float)healthTotal / 100.0f;
			float newValue = Mathf.Clamp (healthValueForBar, 0f, 1f);
			HealthImageObj.fillAmount = newValue;
			if (healthTotal < 0) {
				healthTotal = 0;
			}
			healthTextObj.text = ""+healthTotal+"%";
		}
	}

	public void IncrementHealth()
	{
		healthTextGameObject.healthGui += 10;
		if (healthTextGameObject.healthGui > 100) {
			healthTextGameObject.healthGui = 100;
		}
//		if (healthTotal > 100) {
//			healthTotal = 100;
//		}
	}
}
