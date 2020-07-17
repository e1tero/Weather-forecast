using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UIHelper : MonoBehaviour
{
    public Text Freq1;
    public Text Freq2;
    public Text Freq3;

    public Text _Time;

    public Text Days;
    public Text Hours;

    public WeatherScript weather;


    public void Update()
    {
        _Time.text = weather.time.ToString();
        Hours.text = (weather.time % 24).ToString("0");
        Days.text = Math.Truncate(weather.time / 24).ToString("0");
    }
    public void StopUIButton()
    {
        Freq1.text = weather.freqArray[0].ToString();
        Freq2.text = weather.freqArray[1].ToString();
        Freq3.text = weather.freqArray[2].ToString();
    }

    public void StartUIButton()
    {
        Freq1.text = "Freq_1".ToString();
        Freq2.text = "Freq_2".ToString();
        Freq3.text = "Freq_3".ToString();
    }
}
