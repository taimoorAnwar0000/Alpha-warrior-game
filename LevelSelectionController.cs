using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelSelectionController : IMenuController
{



    public int currentUnlockedLevel = 0;

    public GameObject[] Locks;



    public GameObject Base01Panel;
    public GameObject Base02Panel;
    public GameObject Base03Panel;



    public GameObject[] LocksBase01;
    public GameObject[] LocksBase02;
    public GameObject[] LocksBase03;


    public Text totalScoreText;
    public Text totalCoinsText;


    void OnEnable()
    {
        Debug.Log("Base ID " + DataCentre.UnlockLevel1[1]);

        DataCentre.Load();

        if (DataCentre.BaseID == 1)
        {
            Base01Panel.SetActive(true);
        }
        else if (DataCentre.BaseID == 2)
        {
            Base02Panel.SetActive(true);
        }
        else if (DataCentre.BaseID == 3)
        {
            Base03Panel.SetActive(true);
        }


        for (int i = 0; i < DataCentre.UnlockLevel1.Length; i++)
        {
            if (DataCentre.UnlockLevel1[i])
            {
                DataCentre.CurrentLevel = i;
                LocksBase01[i].SetActive(false);
            }
        }

        for (int i = 0; i < DataCentre.UnlockLevel2.Length; i++)
        {
            if (DataCentre.UnlockLevel2[i])
            {
                DataCentre.CurrentLevel = i;
                LocksBase02[i].SetActive(false);
            }
        }

        for (int i = 0; i < DataCentre.UnlockLevel3.Length; i++)
        {
            if (DataCentre.UnlockLevel3[i])
            {
                DataCentre.CurrentLevel = i;
                LocksBase03[i].SetActive(false);
            }
        }

        totalCoinsText.text = DataCentre.Coins.ToString();
        totalScoreText.text = DataCentre.SCORE.ToString();

        if (DataCentre.NOADS == 0)
        {
            //	AdManager.Instance.ShowSequence (1);
            //	AdManager.Instance.ShowBanner ();
        }



        Screen.sleepTimeout = SleepTimeout.NeverSleep;

    }
    void OnDisable()
    {
        Base01Panel.SetActive(false);
        Base02Panel.SetActive(false);
        Base03Panel.SetActive(false);

    }

    public void LoadLevel(int levelNumber)
    {
        // Check if The Level is Locked
        DataCentre.CurrentLevel = levelNumber - 1;
        if (DataCentre.BaseID == 1)
        {
            MenuManager.Instance.LoadScene("Gameplay");
        }
        if (DataCentre.BaseID == 2)
        {
            MenuManager.Instance.LoadScene("MyGameScene1");
        }
        if (DataCentre.BaseID == 3)
        {
            MenuManager.Instance.LoadScene("MyGameScene2");
        }

    }



}
