using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Variables : MonoBehaviour
{
    bool showClouds = true;
    bool showRain = true;
    bool showSnow = true;
    bool showSky = true;
    bool showStars = true;
    bool showSun_and_Moon = true;
    bool showFog = true;

    private void ShowClouds() // One variable = one method
    {
        if (showClouds == true)
        {
            showClouds = false;
        }
        else
        {
            showClouds = true;
        }
    }
}
   

