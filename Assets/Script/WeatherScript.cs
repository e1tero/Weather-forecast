using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class WeatherScript : MonoBehaviour
{
    //UI
    public Text Weather;

    public double time = 0;
    public double next = 0;

    private int currentWeather = 0;
    public int nextWeather = 0;

    private System.Random random = new System.Random();
    public float[] freqArray = new float[3] { 0f, 0f, 0f };
    private int sum = 0;

    //matrix of infinitesimal coefficients
    private float[,] matrixOfInfCoeff = new float[3, 3] { { -0.4f, 0.3f, 0.1f },  { 0.4f, -0.8f, 0.4f }, { 0.1f, 0.4f, -0.5f } };

    public void StopButton()
    {
        Time.timeScale = 0;
        
        for (int i = 0; i < 3; i++)
        {
            freqArray[i] = freqArray[i] / sum;
        }
    }

    public void StartButton()
    {
        Time.timeScale = 1;
    }

    public void Update()
    {
        time += Time.deltaTime;          
        freqArray[nextWeather]++;
        sum++;
        if (time > next)
        {
            if (nextWeather == 0)
                Weather.text = "Clear";

            else if (nextWeather == 1)
                Weather.text = "Cloudy";

            else if (nextWeather == 2)
                Weather.text = "Overcast";


            double rnd = random.NextDouble();

            //This deltaTime != Time.deltaTime
            double deltaTime = Math.Log(rnd) / matrixOfInfCoeff[currentWeather, currentWeather];

            next = time + deltaTime;
            rnd = random.NextDouble();

            int i = 0;
            while (i < 3)
            {
                if (i != currentWeather)
                {
                    rnd += matrixOfInfCoeff[currentWeather, i] / matrixOfInfCoeff[currentWeather, currentWeather];
                }

                if (rnd < 0)
                {
                    nextWeather = i;
                    currentWeather = i;
                    break;
                }
                i++;
            }

        }
    }
}
