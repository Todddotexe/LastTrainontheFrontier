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
    public GameObject reportPersonal;

    public GameObject reportLight;

    public GameObject tutorial;

    public void Start()
    {
        reportSheet.SetActive(false);
        tutorial.SetActive(true);
    }

    #region Daily Reports
    public void ReportSummon()
    {
        if (DayTracker.currentDay == 1)
        {
            reportText.GetComponent<Text>().text = "Departure successful. All passangers are accounted for and the cargo has been checked. VIP has settled into accomodations nicely.";
            reportPersonal.GetComponent<Text>().text = "On a personal note Captain, our departure was somewhat late for the season. A small but palpable tension can be felt amongst the passangers. I will let you know if morale is severly impacted, but for now it would be best to keep the temperment of your passengers in mind.";
            DayTracker.bedButton.SetActive(true);
        }
        if (DayTracker.currentDay == 2)
        {
            reportText.GetComponent<Text>().text = "[No Report]";
            reportPersonal.GetComponent<Text>().text = " ";
        }
        if (DayTracker.currentDay == 3)
        {
            if (IntercomTracker.Stowaway == true)
            {
                reportText.GetComponent<Text>().text = "All passangers accounted for, cargo levels stable. VIP is comfortable, save for minor distasteful remarks. Stowaway situation unchanged, medical staff monitoring.";
                reportPersonal.GetComponent<Text>().text = "As per my last report Captain, I'll continue to update you in an unofficial capacity. Morale appears to be on the rise, especially among the workers. The VIP doesn't seem too happy with the potential risk, but I've managed to calm him. All in all, as long as we have no upsets, it looks as though we've settled in for an easy journey.";
            }
            if (IntercomTracker.Stowaway == false)
            {
                reportText.GetComponent<Text>().text = "All passangers accounted for, cargo levels stable. VIP is comfortable.";
                reportPersonal.GetComponent<Text>().text = "As per my last report Captain, I'll continue to update you in an unofficial capacity. Morale is declined slightly, with a few clusters of passangers whispering about your decision to remove the Stowaway. While I understand the logic behind your decision, some are taking it as an act of an abuse of authority. I've done my best to calm them, but the VIP seems content with making snide remarks to other passangers that only aggrivate them furthur. I'll let you know if things get out of hand.";
            }
            DayTracker.bedButton.SetActive(true);
        }
        if (DayTracker.currentDay == 4)
        {
            if (IntercomTracker.Stowaway == true)
            {
                reportText.GetComponent<Text>().text = "All passangers accounted for, cargo levels stable. VIP remains cautious. Stowaway has become agitated, medical staff monitoring, travel between passanger cars has been minimized.";
                reportPersonal.GetComponent<Text>().text = "Captain, it appears there may be cause for concern afterall. While the general mood remains optomistic, a small feeling of unease has seeped into the passangers given the Stowaways development. Medical staff are unsure if its even any sort of sickness, or just the temperment of the Stowaway. I'll let you know as soon as it becomes clear, but for now I've limited the travel of the passangers between cars.";
            }
            if (IntercomTracker.Stowaway == false)
            {
                reportText.GetComponent<Text>().text = "All passangers accounted for, cargo levels stable. VIP has expressed agitation at a handful of passangers, but is otherwise in good health.";
                reportPersonal.GetComponent<Text>().text = "Captain, it appears some discourse has errupted within the populace. The VIP's remarks have elevated to lecturing, and the passangers whispers have elevated into loud discussion. Combined, they have created an environment of arguements. Several times this morning I have been called to seperate the fueding parties. While I normally wouldn't inform you of the petty squabbles of your passangers, I thought it would be best for you to be notified early, and to expect an ultimatum in the coming days.";
            }
            DayTracker.bedButton.SetActive(true);
        }
        if (DayTracker.currentDay == 5)
        {
            reportText.GetComponent<Text>().text = "[No Report]";
            reportPersonal.GetComponent<Text>().text = " ";
        }
        if (DayTracker.currentDay == 6)
        {
            if (IntercomTracker.Stowaway == true)
            {
                if (IntercomTracker.Outbreak == true)
                {
                    reportText.GetComponent<Text>().text = "All passangers accounted for (initially some were missing), cargo levels stable. VIP is healthy, but has taken to self isolation. Quarantine holding stable.";
                    reportPersonal.GetComponent<Text>().text = "Captain, I fear the sickness may be out of hand, and Quarantine has come too late. Several passangers that had previously been cleared has now comeback positive, with several being found lurking in the supply car during the morning count. I blame myself for not treating this issue with more urgency. Medical staff have maintained that the sickness will pass, so I will do my duty and attempt to curb its spread.";
                }
                if (IntercomTracker.Outbreak == false)
                {
                    reportText.GetComponent<Text>().text = "Healthy passangers accounted for, cargo levels above projected loss. VIP is comfortable. Last aflicted passangers have been ejected.";
                    reportPersonal.GetComponent<Text>().text = "It is done. Overall, 13 souls were ejected from the train last night, including the Stowaway and several medical personnel. Though it was a hard choice, it is my duty to inform you that our employeers expected losses on this journey, and so any anxiety you may feel about the security of your job is unfounded. I know its not a comforting thing to hear, but you must persevere for the sake of your remaing passangers.";
                }
            }
            if (IntercomTracker.Stowaway == false)
            {
                if (IntercomTracker.Dispute == true)
                {
                    reportText.GetComponent<Text>().text = "All passangers accounted for, cargo levels stable. VIP is in high spirits.";
                    reportPersonal.GetComponent<Text>().text = "Captain, I'm concerned. We're yet to reach our first checkpoint, and already I feel a strong sense of division within the train. The VIP trots around, comfortable in your support of him, while the passangers hush their conversations whenever a member of staff walks by. I understand it is part of your duty to ensure the comfort of the VIP, but its reached the point of being at the expense of the passangers. Next time a decision is too be made, the passangers may just make it for you.";
                }
                if (IntercomTracker.Dispute == false)
                {
                    reportText.GetComponent<Text>().text = "All passangers accounted for, cargo levels stable. VIP has expressed agitation.";
                    reportPersonal.GetComponent<Text>().text = "I know it must have been hard, going against your orders Captain. But the mood aboard has brightened considerably. While the VIP sits dejected and quiet, the other passangers rejoice quietly that they aren't subject to a tone deaf Captain. Undoubtedly this decision will come back to bite you eventually, but for now the train is at peace.";
                }
            }
            DayTracker.bedButton.SetActive(true);
        }
        if (DayTracker.currentDay == 7)
        {
            reportText.GetComponent<Text>().text = "[No Report]";
            reportPersonal.GetComponent<Text>().text = " ";
        }
        reportSheet.SetActive(true);
        reportLight.SetActive(false);
    }
    #endregion

    public void CloseReport()
    {
        reportSheet.SetActive(false);
    }

    public void CloseTutorial()
    {
        tutorial.SetActive(false);
    }
}
