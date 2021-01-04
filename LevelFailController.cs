using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelFailController : IMenuController
{

    public IMenuController mainMenu;

    public Text totalScoreText;
    public Text totalCoinsText;

    void OnEnable()
    {

        AdsManager._instance.ShowInterstitial();
        totalCoinsText.text = DataCentre.Coins.ToString();
        totalScoreText.text = DataCentre.SCORE.ToString();
        Time.timeScale = 0;
        //GPGManager.Instance.postScore (DataCentre.SCORE);
        if (DataCentre.NOADS == 0)
        {
            //	AdManager.Instance.ShowSequence (1);
        }

        this.setPreviousMenu(null);
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    void OnDisable()
    {
        Time.timeScale = 1;
    }


    public void Restart()
    {
        // AdsManager._instance.ShowInterstitial();
        Time.timeScale = 1;
        MenuManager.Instance.LoadScene(Application.loadedLevel);

        //AdsManager.Instance.ShowInterUnityAds();
        //		Application.LoadLevel (Application.loadedLevel);
        //		this.SwitchPreviousMenu ();
    }

    public void Menu()
    {
        // AdsManager._instance.ShowInterstitial();
        Time.timeScale = 1;
        Application.LoadLevel(1);
        this.SwitchNextMenu(mainMenu);


        //if (DataCentre.NOADS == 0) {
        //AdManager.Instance.ShowSequence (2);
        //}
    }

    public void More()
    {

    }


    public override void Update()
    {

    }
}
