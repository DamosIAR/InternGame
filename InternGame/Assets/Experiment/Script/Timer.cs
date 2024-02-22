using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    float timerTime;
    public float maxTime;
    public GameObject finishPanel;

    private void Start()
    {
        finishPanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (timerTime < maxTime)
        {
            timerTime += Time.deltaTime;
        }
        else if (timerTime >= maxTime)
        {
            finishPanel.gameObject.SetActive(true);
            timerTime = maxTime;
        }
        
        int minutes = (int)timerTime / 60;
        int seconds = (int)timerTime % 60;
        timerText.text = string.Format("{00:00} : {01:00}", minutes, seconds);
    }
}
