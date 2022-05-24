using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class DayTracker : MonoBehaviour
{
    public IntercomTracker2 intercomTracker;
    public ReportTracker reportTracker;

    DayTracker gameManager;

    public GameObject bedButton;
    public GameObject dayText;
    public int currentDay;

    void Awake()
    {
        gameManager = GameObject.Find("ManagerObj").GetComponent<DayTracker>();
    }

    private void Start()
    {
        bedButton.SetActive(false);
    }

    public void GoToSleep()
    {
        currentDay++;
        dayText.GetComponent<Text>().text = "Day:" + currentDay.ToString();
        bedButton.SetActive(false);
        reportTracker.reportLight.SetActive(true);
    }
}
