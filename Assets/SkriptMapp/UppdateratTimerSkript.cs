using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UppdateratTimerSkript : MonoBehaviour
{
    public Text TimerText;
    public float StartaTimer;

    // Use this for initialization
    void Start()
    {
        StartaTimer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float f = StartaTimer + Time.time;
        string Minuter = ((int)f / 60).ToString();
        string Sekunder = (f % 60).ToString("f2");
        TimerText.text = Sekunder;
    }
}
