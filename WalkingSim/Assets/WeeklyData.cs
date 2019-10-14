using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mewlist;

public class WeeklyData : MonoBehaviour
{

    public int currentDay = -1;
    public MassiveClouds clouds;
    public MassiveCloudsProfile[] dailyCloudProfile;
    public GameObject[] dailylightProfile;


    // Start is called before the first frame update
    void Start()
    {
        currentDay += 1;
        WeeklyWeatherCycle();
    }

    void WeeklyWeatherCycle()
    {
        switch (currentDay)
        {
            case 0:
                clouds.Profiles[0] = dailyCloudProfile[0];
                break;
            case 1:
                clouds.Profiles[0] = dailyCloudProfile[1];
                break;
            case 2:
                clouds.Profiles[0] = dailyCloudProfile[2];
                break;
            case 3:
                clouds.Profiles[0] = dailyCloudProfile[3];
                break;
            case 4:
                clouds.Profiles[0] = dailyCloudProfile[4];
                break;
            case 5:
                clouds.Profiles[0] = dailyCloudProfile[5];
                break;
            case 6:
                clouds.Profiles[0] = dailyCloudProfile[6];
                break;
        }
    }

}

