using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerS : MonoBehaviour
{
    public Text timer;
   
    void Update()
    {
        float start = Time.time;
        string minutes = ((int)start / 60).ToString();
        string seconds = (start % 60).ToString("f2");
        timer.text = "Time:" + minutes + ":" + seconds;
    }
}

