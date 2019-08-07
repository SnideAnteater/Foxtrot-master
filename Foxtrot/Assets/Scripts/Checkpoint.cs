using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Checkpoint : MonoBehaviour
{
    [SerializeField]
    Text logLabel;
    [SerializeField]
    Text TimeLabel;
    [SerializeField]
    Text WinTimeLabel;
    [SerializeField]
    CanvasGroup Gameplay;
    [SerializeField]
    CanvasGroup Win;
    [SerializeField]
    GameObject winButtons;

    private bool checkpoint1;
    private bool checkpoint2;
    private bool checkpoint3;
    private bool checkpoint4;
    private bool checkpoint5;
    private bool checkpoint6;
    private bool checkpoint7;
    private bool checkpoint8;
    public bool checkpoint9 = false;
    private int checks = 0;
    private float secondsCount;
    private int minuteCount;

    private void Update()
    {
        if(checkpoint9 == false)
        {
            UpdateTimerUI();
            logLabel.text = checks.ToString();
        }
        else
        {
            winButtons.SetActive(true);
            Gameplay.alpha = 0;
            Win.alpha = 1;
            
        }
    }

    public void UpdateTimerUI()
    {

            //set timer UI
            secondsCount += Time.deltaTime;
            TimeLabel.text = minuteCount + "m:" + (int)secondsCount + "s";
            WinTimeLabel.text = minuteCount + "m:" + (int)secondsCount + "s";
            if (secondsCount >= 60)
            {
                minuteCount++;
                secondsCount = 0;
            }

    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "checkpoint1")
        {
            checkpoint1 = true;
            checkpoint9 = true;
            checks = 1;
        }
        else if (other.tag == "checkpoint2" && checkpoint1 == true)
        {
            checkpoint2 = true;
            checks = 2;
        }
        else if (other.tag == "checkpoint3" && checkpoint2 == true)
        {
            checkpoint3 = true;
            checks = 3;
        }
        else if (other.tag == "checkpoint4" &&  checkpoint3 == true )
        {
            checkpoint4 = true;
            checks = 4;
        }
        else if (other.tag == "checkpoint5" && checkpoint4 == true )
        {
            checkpoint5 = true;
            checks = 5;
        }
        else if (other.tag == "checkpoint6" && checkpoint5 == true )
        {
            checkpoint6 = true;
            checks = 6;
        }
        else if (other.tag == "checkpoint7" && checkpoint6 == true )
        {
            checkpoint7 = true;
            checks = 7;
        }
        else if (other.tag == "checkpoint8" && checkpoint7 == true )
        {
            checkpoint8 = true;
            checks = 8;
        }
        else if (other.tag == "checkpoint9" && checkpoint8 == true )
        {
            checkpoint9 = true;
            checks = 9;
        }

        else
        {
            Debug.Log("Turn Back");
        }

    }


}
