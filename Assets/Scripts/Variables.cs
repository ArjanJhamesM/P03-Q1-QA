using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using TMPro;

public class Variables : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI cloudIndicator;
    [SerializeField] private TextMeshProUGUI rainIndicator;
    [SerializeField] private TextMeshProUGUI snowIndicator;
    [SerializeField] private TextMeshProUGUI skyIndicator;
    [SerializeField] private TextMeshProUGUI starsIndicator;
    [SerializeField] private TextMeshProUGUI sunAndMoonIndicator;
    [SerializeField] private TextMeshProUGUI fogIndicator;


    bool showClouds = true;
    bool showRain = true;
    bool showSnow = true;
    bool showSky = true;
    bool showStars = true;
    bool showSunAndMoon = true;
    bool showFog = true;


    public void ChangeValue(ref bool showSetting, ref TextMeshProUGUI settingIndicator)
    {

        if (showSetting == true)
        {
            showSetting = false;
            settingIndicator.text = "OFF";
            print(showSetting);
        }
        else if (showSetting == false)
        {
            showSetting = true;
            settingIndicator.text = "ON";
            print(showSetting);
        }
    }

    public void ShowClouds()
    {
        ChangeValue(ref showClouds, ref cloudIndicator);
    }

    public void ShowRain()
    {
        ChangeValue(ref showRain, ref rainIndicator);
    }

    public void ShowSnow()
    {
        ChangeValue(ref showSnow, ref snowIndicator);
    }

    public void ShowSky()
    {
        ChangeValue(ref showSky, ref skyIndicator);
    }

    public void ShowStars()
    {
        ChangeValue(ref showStars, ref starsIndicator);
    }

    public void ShowSunAndMoon()
    {
        ChangeValue(ref showSunAndMoon, ref sunAndMoonIndicator);
    }

    public void ShowFog()
    {
        ChangeValue(ref showFog, ref fogIndicator);
    }
}
   

