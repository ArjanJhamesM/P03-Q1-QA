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

    private void Statements()

    {
        if (showClouds == true)
        {
            showClouds = false;
        }
        else
        {
            showClouds = true;
        }
       
        if (showRain == true)
        {
            showRain = false;
        }
        else
        {
            showRain = true;
        }
       
        if (showSnow == true)
        {
            showSnow = false;
        }
        else
        {
            showSnow = true;
        }
       
        if (showSky == true)
        {
            showSky = false;
        }
        else
        {
            showSky = true;
        }
        
        if (showStars == true)
        {
            showStars = false;
        }
        else
        {
            showStars = true;
        }
       
        if (showSun_and_Moon == true)
        {
            showSun_and_Moon = false;
        }
        else
        {
            showSun_and_Moon = true;
        }
        
        if (showFog == true)
        {
            showFog = false;
        }
        else
        {
            showFog = true;
        }

    }



}
   

