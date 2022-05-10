using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReportTracker : MonoBehaviour
{
    public DayTracker DayTracker;
    public IntercomTracker2 IntercomTracker;

    public GameObject reportSheet;
    public GameObject reportText;

    public void Start()
    {
        reportSheet.SetActive(false);
    }

    #region Daily Reports
    public void ReportSummon()
    {
        if (DayTracker.currentDay == 1)
        {
            reportText.GetComponent<Text>().text = "departure";
            DayTracker.bedButton.SetActive(true);
        }
        if (DayTracker.currentDay == 2)
        {
            reportText.GetComponent<Text>().text = "[No Report]";
        }
        if (DayTracker.currentDay == 3)
        {
            if (IntercomTracker.Stowaway == true)
            {
                reportText.GetComponent<Text>().text = "(confined1)";
            }
            if (IntercomTracker.Stowaway == false)
            {
                reportText.GetComponent<Text>().text = "(ejected1)";
            }
            DayTracker.bedButton.SetActive(true);
        }
        if (DayTracker.currentDay == 4)
        {
            if (IntercomTracker.Stowaway == true)
            {
                reportText.GetComponent<Text>().text = "(confined2)";
            }
            if (IntercomTracker.Stowaway == false)
            {
                reportText.GetComponent<Text>().text = "(ejected2)";
            }
            DayTracker.bedButton.SetActive(true);
        }
        if (DayTracker.currentDay == 5)
        {
            reportText.GetComponent<Text>().text = "[No Report]";
        }
        if (DayTracker.currentDay == 6)
        {
            if (IntercomTracker.Stowaway == true)
            {
                if (IntercomTracker.Outbreak == true)
                {
                    reportText.GetComponent<Text>().text = "quarantine1";
                }
                if (IntercomTracker.Outbreak == false)
                {
                    reportText.GetComponent<Text>().text = "purge1";
                }
            }
            if (IntercomTracker.Stowaway == false)
            {
                if (IntercomTracker.Dispute == true)
                {
                    reportText.GetComponent<Text>().text = "VIP1";
                }
                if (IntercomTracker.Dispute == false)
                {
                    reportText.GetComponent<Text>().text = "Workers1";
                }
            }
            DayTracker.bedButton.SetActive(true);
        }
        if (DayTracker.currentDay == 7)
        {
            reportText.GetComponent<Text>().text = "[No Report]";
        }
        if (DayTracker.currentDay == 8)
        {
            if (IntercomTracker.Stowaway == true)
            {
                if (IntercomTracker.Outbreak == true)
                {
                    if (IntercomTracker.Sabotage == true)
                    {
                        reportText.GetComponent<Text>().text = "Under Supplied Ending";
                    }
                    if (IntercomTracker.Sabotage == false)
                    {
                        reportText.GetComponent<Text>().text = "For Nothing at All Ending";
                    }
                }
                if (IntercomTracker.Outbreak == false)
                {
                    if (IntercomTracker.Surgery == true)
                    {
                        reportText.GetComponent<Text>().text = "The Last Step Ending";
                    }
                    if (IntercomTracker.Surgery == false)
                    {
                        reportText.GetComponent<Text>().text = "Hardest Choices Ending";
                    }
                }
            }
            if (IntercomTracker.Stowaway == false)
            {
                if (IntercomTracker.Dispute == true)
                {
                    if (IntercomTracker.Murdered == true)
                    {
                        reportText.GetComponent<Text>().text = "Knives Out Ending";
                    }
                    if (IntercomTracker.Murdered == false)
                    {
                        reportText.GetComponent<Text>().text = "New Policy Ending";
                    }
                }
                if (IntercomTracker.Dispute == false)
                {
                    if (IntercomTracker.Complaint == true)
                    {
                        reportText.GetComponent<Text>().text = "Shaky Job Ending";
                    }
                    if (IntercomTracker.Complaint == false)
                    {
                        reportText.GetComponent<Text>().text = "Powerful Enemy Ending";
                    }
                }
            }
        }
        reportSheet.SetActive(true);
    }
    #endregion

    public void CloseReport()
    {
        reportSheet.SetActive(false);
    }
}
