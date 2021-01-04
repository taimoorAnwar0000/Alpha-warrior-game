using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Baseslection : IMenuController
{


    public int currentUnlockedBase = 0;

    public GameObject[] Locks;

    public Text totalScoreText;
    public Text totalCoinsText;

    void OnEnable()
    {
        //AdsManager._instance.ShowInterstitial();
        for (int i = 0; i < DataCentre.UnlockBase.Length; i++)
        {
            if (DataCentre.UnlockBase[i])
            {
                Locks[i].SetActive(false);
            }
        }

        totalCoinsText.text = DataCentre.Coins.ToString();
        totalScoreText.text = DataCentre.SCORE.ToString();

        Screen.sleepTimeout = SleepTimeout.NeverSleep;

    }
    void OnDisable()
    {

    }

    public void Base01()
    {
        DataCentre.BaseID = 1;
    }
    public void Base02()
    {
        DataCentre.BaseID = 2;
    }
    public void Base03()
    {
        DataCentre.BaseID = 3;
    }


}