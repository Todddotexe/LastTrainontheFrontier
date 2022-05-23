using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScript : MonoBehaviour
{
    public DayTracker DayTracker;
    public IntercomTracker2 IntercomTracker;

    public GameObject finalSlide;
    public GameObject title;
    public GameObject endText;

    public GameObject bedButton;
    public GameObject intercomButton;
    public GameObject reportButton;

    void Start()
    {
        finalSlide.SetActive(false);
    }

    void Update()
    {
        if (DayTracker.currentDay == 8)
        {
            finalSlide.SetActive(true);

            bedButton.SetActive(false);
            intercomButton.SetActive(false);
            reportButton.SetActive(false);

            EndGame();
        }
    }

    public void EndGame()
    {
        if (IntercomTracker.Stowaway == true && IntercomTracker.Outbreak == true && IntercomTracker.Sabotage == true)
        {
            title.GetComponent<Text>().text = "Under Supplied";
            endText.GetComponent<Text>().text = "We've made it to the first checkpoint, but we still have miles of track to go. Your decisions have kept us all alive, but at a cost. Without the supply car, we will be subject to shortage and hardship. There may come a time where the passangers aren't so grateful for your decision to save all of them.";
        }
        if (IntercomTracker.Stowaway == true && IntercomTracker.Outbreak == true && IntercomTracker.Sabotage == false)
        {
            title.GetComponent<Text>().text = "Breaking Point";
            endText.GetComponent<Text>().text = "We've made it to the first checkpoint, but we still have miles of track to go. Try as you might to keep everyone alive, last night saw our breaking point in facing this illness. We continue our journey not short on supply of food and medicine, but short on supply of friends and family.";
        }
        if (IntercomTracker.Stowaway == true && IntercomTracker.Outbreak == false && IntercomTracker.Surgery == true)
        {
            title.GetComponent<Text>().text = "So Close...";
            endText.GetComponent<Text>().text = "We've made it to the first checkpoint, but we still have miles of track to go. In the early hours of the morning, the VIP died on the operating table. His death marks a massive failure of your duties as Captain. Despite that, you are the only one fit to steer the train to the end of its journey.";
        }
        if (IntercomTracker.Stowaway == true && IntercomTracker.Outbreak == false && IntercomTracker.Surgery == false)
        {
            title.GetComponent<Text>().text = "Barely Alive";
            endText.GetComponent<Text>().text = "We've made it to the first checkpoint, but we still have miles of track to go. It was close, but the VIP proved tenacious enough to hold on. The checkpoint has what we need for a full recovery. This has been a dark chapter in our journey, I can only hope the future is brighter.";
        }
        if (IntercomTracker.Stowaway == false && IntercomTracker.Dispute == true && IntercomTracker.Murdered == true)
        {
            title.GetComponent<Text>().text = "Knives Out";
            endText.GetComponent<Text>().text = "We've made it to the first checkpoint, but we still have miles of track to go. ";
        }
        if (IntercomTracker.Stowaway == false && IntercomTracker.Dispute == true && IntercomTracker.Murdered == false)
        {
            title.GetComponent<Text>().text = "New Normal";
            endText.GetComponent<Text>().text = "";
        }
        if (IntercomTracker.Stowaway == false && IntercomTracker.Dispute == false && IntercomTracker.Complaint == true)
        {
            title.GetComponent<Text>().text = "Uncertainty";
            endText.GetComponent<Text>().text = "";
        }
        if (IntercomTracker.Stowaway == false && IntercomTracker.Dispute == false && IntercomTracker.Complaint == false)
        {
            title.GetComponent<Text>().text = "Rivalry";
            endText.GetComponent<Text>().text = "";
        }
    }
}
