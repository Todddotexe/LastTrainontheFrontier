using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntercomTracker2 : MonoBehaviour
{
    public DayTracker DayTracker;
    public ReportTracker ReportTracker;

    public GameObject choiceTitle;

    public GameObject intercomButton;

    public GameObject ChoiceMenu;

    public bool Stowaway = false;
    public bool Outbreak = false;
    public bool Dispute = false;
    public bool Sabotage = false;
    public bool Surgery = false;
    public bool Murdered = false;
    public bool Complaint = false;

    public void Start()
    {
        ChoiceMenu.SetActive(false);
    }

    public void Choice()
    {
        if (DayTracker.currentDay == 2)
        {
            choiceTitle.GetComponent<Text>().text = "STOWAWAY";
            ChoiceMenu.SetActive(true);
        }

        if (DayTracker.currentDay == 5)
        {
            if (Stowaway == true)
            {
                choiceTitle.GetComponent<Text>().text = "OUTBREAK";
            }
            if (Stowaway == false)
            {
                choiceTitle.GetComponent<Text>().text = "DISPUTE";
            }
            ChoiceMenu.SetActive(true);
        }
        if (DayTracker.currentDay == 7)
        {
            if (Stowaway == true && Outbreak == true)
            {
                choiceTitle.GetComponent<Text>().text = "SABOTAGE";
            }
            if (Stowaway == true && Outbreak == false)
            {
                choiceTitle.GetComponent<Text>().text = "SURGERY";
            }
            if (Stowaway == false && Dispute == true)
            {
                choiceTitle.GetComponent<Text>().text = "MURDERED";
            }
            if (Stowaway == false && Dispute == false)
            {
                choiceTitle.GetComponent<Text>().text = "COMPLAINT";
            }
            ChoiceMenu.SetActive(true);
        }
    }

    // FIRST CHOICE
    public void Confine()
    {
        if (DayTracker.currentDay == 2)
        {
            Stowaway = true;
            DayTracker.bedButton.SetActive(true);
            ChoiceMenu.SetActive(false);
            intercomButton.SetActive(false);
        }
    }
    public void Eject()
    {
        if (DayTracker.currentDay == 2)
        {
            Stowaway = false;
            DayTracker.bedButton.SetActive(true);
            ChoiceMenu.SetActive(false);
            intercomButton.SetActive(false);
        }
    }
    
    // SECOND CHOICE
    public void Quarantine()
    {
        if (DayTracker.currentDay == 5 && Stowaway == true)
        {
            Outbreak = true;
            DayTracker.bedButton.SetActive(true);
            ChoiceMenu.SetActive(false);
            intercomButton.SetActive(false);
        }
    }
    public void Purge()
    {
        if (DayTracker.currentDay == 5 && Stowaway == true)
        {
            Outbreak = false;
            DayTracker.bedButton.SetActive(true);
            ChoiceMenu.SetActive(false);
            intercomButton.SetActive(false);
        }
    }
    public void VIP()
    {
        if (DayTracker.currentDay == 5 && Stowaway == false)
        {
            Dispute = true;
            DayTracker.bedButton.SetActive(true);
            ChoiceMenu.SetActive(false);
            intercomButton.SetActive(false);
        }
    }
    public void Workers()
    {
        if (DayTracker.currentDay == 5 && Stowaway == false)
        {
            Dispute = false;
            DayTracker.bedButton.SetActive(true);
            ChoiceMenu.SetActive(false);
            intercomButton.SetActive(false);
        }
    }

    // THIRD CHOICE
    public void Supply()
    {
        if (DayTracker.currentDay == 7 && Stowaway == true && Outbreak == true)
        {
            Sabotage = true;
            DayTracker.bedButton.SetActive(true);
            ChoiceMenu.SetActive(false);
            intercomButton.SetActive(false);
        }
    }
    public void Personnel()
    {
        if (DayTracker.currentDay == 7 && Stowaway == true && Outbreak == true)
        {
            Sabotage = false;
            DayTracker.bedButton.SetActive(true);
            ChoiceMenu.SetActive(false);
            intercomButton.SetActive(false);
        }
    }
    public void Risk()
    {
        if (DayTracker.currentDay == 7 && Stowaway == true && Outbreak == false)
        {
            Surgery = true;
            DayTracker.bedButton.SetActive(true);
            ChoiceMenu.SetActive(false);
            intercomButton.SetActive(false);
        }
    }
    public void Safe()
    {
        if (DayTracker.currentDay == 7 && Stowaway == true && Outbreak == false)
        {
            Surgery = false;
            DayTracker.bedButton.SetActive(true);
            ChoiceMenu.SetActive(false);
            intercomButton.SetActive(false);
        }
    }
    public void Report()
    {
        if (DayTracker.currentDay == 7 && Stowaway == false && Dispute == true)
        {
            Murdered = true;
            DayTracker.bedButton.SetActive(true);
            ChoiceMenu.SetActive(false);
            intercomButton.SetActive(false);
        }
    }
    public void Blind()
    {
        if (DayTracker.currentDay == 7 && Stowaway == false && Dispute == true)
        {
            Murdered = false;
            DayTracker.bedButton.SetActive(true);
            ChoiceMenu.SetActive(false);
            intercomButton.SetActive(false);
        }
    }
    public void Accept()
    {
        if (DayTracker.currentDay == 7 && Stowaway == false && Dispute == false)
        {
            Complaint = true;
            DayTracker.bedButton.SetActive(true);
            ChoiceMenu.SetActive(false);
            intercomButton.SetActive(false);
        }
    }
    public void Misplace()
    {
        if (DayTracker.currentDay == 7 && Stowaway == false && Dispute == false)
        {
            Complaint = false;
            DayTracker.bedButton.SetActive(true);
            ChoiceMenu.SetActive(false);
            intercomButton.SetActive(false);
        }
    }

}
