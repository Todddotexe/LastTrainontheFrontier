using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntercomTracker2 : MonoBehaviour
{
    public DayTracker DayTracker;
    public ReportTracker ReportTracker;

    public GameObject choiceTitle;
    public GameObject choiceText;
    public GameObject option1Text;
    public GameObject option2Text;

    public GameObject intercomButton;

    public GameObject ChoiceMenu;

    public bool Stowaway = false;
    public bool Outbreak = false;
    public bool Dispute = false;
    public bool Sabotage = false;
    public bool Surgery = false;
    public bool Murdered = false;
    public bool Complaint = false;

    public bool firstChoiceMade = false;
    public bool secondChoiceMade = false;
    public bool thirdChoiceMade = false;

    public void Start()
    {
        ChoiceMenu.SetActive(false);
        intercomButton.SetActive(false);
    }

    public void Update()
    {
        if (DayTracker.currentDay == 2 && firstChoiceMade == false)
        {
            intercomButton.SetActive(true);
        }
        if (DayTracker.currentDay == 5 && secondChoiceMade == false)
        {
            intercomButton.SetActive(true);
        }
        if (DayTracker.currentDay == 7 && thirdChoiceMade == false)
        {
            intercomButton.SetActive(true);
        }
    }

    public void Choice()
    {
        if (DayTracker.currentDay == 2)
        {
            choiceTitle.GetComponent<Text>().text = "STOWAWAY";
            choiceText.GetComponent<Text>().text = "Sir, A stowaway has been found hiding in the supply carraige. He claims to be the brother of one of the staff members aboard. The passangers are divided about what to do with him, but the choice is yours. The supply carraige doesn't have the same protection as the personnel carriages, so theres no knowing if this stowaway has contracted any number of the strange illnesses that plauge the frontier. What are your orders?";
            option1Text.GetComponent<Text>().text = "Confine";
            option2Text.GetComponent<Text>().text = "Eject";
        }

        if (DayTracker.currentDay == 5)
        {
            if (Stowaway == true)
            {
                choiceTitle.GetComponent<Text>().text = "OUTBREAK";
                choiceText.GetComponent<Text>().text = "Sir, your orders are required urgently! I fear our stowaway was carrying a sickness afterall. It's not harmful, but the virus induces episodes of paranoia in those aflicted. Our medical staff have assured me that the virus will pass eventually, but while it grips the train theres no telling what kind of damage could be done by the aflicted. We could set up a quarantine in one of the passanger cars, or...";
                option1Text.GetComponent<Text>().text = "Quarantine";
                option2Text.GetComponent<Text>().text = "Purge";
            }
            if (Stowaway == false)
            {
                choiceTitle.GetComponent<Text>().text = "DISPUTE";
                choiceText.GetComponent<Text>().text = "Sir, the situation has developed. It appears the on going discourse between our VIP and the workers has reached a climax. The VIP has demanded you publically 'support' his position of power and repremand the workers for arguing against him. You know my feelings on the issue sir, but the choice remains yours. Who will you support?";
                option1Text.GetComponent<Text>().text = "The VIP";
                option2Text.GetComponent<Text>().text = "The Workers";
            }
        }
        if (DayTracker.currentDay == 7)
        {
            if (Stowaway == true && Outbreak == true)
            {
                choiceTitle.GetComponent<Text>().text = "SABOTAGE";
                choiceText.GetComponent<Text>().text = "Sir, I'm afraid you have a difficult decision to make. While the quarantine was largely affective as containing the spread of the virus, a few aflicted personnel were able to avoid detection. Damages have been discovered on the supply carraige and the personnel carraige being used for quarantine. Unfortunatly we only have the materials to repair one carraige. The other will need to be detached. An upcoming turn off would allow us to detach the personnel carraige without losing the supply carraige. There is one more thing sir. I'm afraid to report that we do not have the room to move all of our supplies if we get rid of the supply car... nor the room for passangers should we do the opposite. I'm sorry sir, but this will not be an easy decision, as we will be severely undersupplied if you choose to save everyone. What carraige will we remove sir?";
                option1Text.GetComponent<Text>().text = "Supply";
                option2Text.GetComponent<Text>().text = "Personnel";
            }
            if (Stowaway == true && Outbreak == false)
            {
                choiceTitle.GetComponent<Text>().text = "SURGERY";
                choiceText.GetComponent<Text>().text = "";
                option1Text.GetComponent<Text>().text = "";
                option2Text.GetComponent<Text>().text = "";
            }
            if (Stowaway == false && Dispute == true)
            {
                choiceTitle.GetComponent<Text>().text = "MURDERED";
                choiceText.GetComponent<Text>().text = "";
                option1Text.GetComponent<Text>().text = "";
                option2Text.GetComponent<Text>().text = "";
            }
            if (Stowaway == false && Dispute == false)
            {
                choiceTitle.GetComponent<Text>().text = "COMPLAINT";
                choiceText.GetComponent<Text>().text = "";
                option1Text.GetComponent<Text>().text = "";
                option2Text.GetComponent<Text>().text = "";
            }
        }
        ChoiceMenu.SetActive(true);
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
            firstChoiceMade = true;
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
            firstChoiceMade = true;
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
            secondChoiceMade = true;
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
            secondChoiceMade = true;
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
            secondChoiceMade = true;
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
            secondChoiceMade = true;
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
            thirdChoiceMade = true;
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
            thirdChoiceMade = true;
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
            thirdChoiceMade = true;
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
            thirdChoiceMade = true;
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
            thirdChoiceMade = true;
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
            thirdChoiceMade = true;
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
            thirdChoiceMade = true;
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
            thirdChoiceMade = true;
        }
    }

}
