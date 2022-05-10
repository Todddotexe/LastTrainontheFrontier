using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class DayTracker : MonoBehaviour
{
    public IntercomTracker2 intercomTracker;

    DayTracker gameManager;

    public GameObject bedButton;
    public GameObject dayText;
    public int currentDay;

    void Awake()
    {
        gameManager = GameObject.Find("ManagerObj").GetComponent<DayTracker>();
    }

    public void GoToSleep()
    {
        currentDay++;
        dayText.GetComponent<Text>().text = "Day:" + currentDay.ToString();
        bedButton.SetActive(false);
    }
}
