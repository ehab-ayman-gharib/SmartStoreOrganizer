using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField] float startTimeSeconds = 30f;
    [SerializeField] TextMeshProUGUI timerText;
    float timeLeft;
    bool isRunning = false;

    public event Action OnTimerEnd;

    void Start()
    {
        Initialize();
    }

    void Update()
    {
        if (!isRunning) return;

        timeLeft -= Time.deltaTime;
        if (timeLeft < 0f)
        {
            timeLeft = 0f;
            isRunning = false;
            OnTimerEnd?.Invoke();
        }

        // Update UI text with integer seconds
        if (timerText != null)
        {
            if(timeLeft >= 10f)
                timerText.text = "00:" + Mathf.CeilToInt(timeLeft).ToString();
            else
                timerText.text = "00:0"+Mathf.CeilToInt(timeLeft).ToString();
        }
    }
     void Initialize()
    {
        timeLeft = startTimeSeconds;
        if (timerText != null)
        {
            timerText.text = "00:" + Mathf.CeilToInt(timeLeft).ToString();
        }
    }
    public void StartTimer()
    {
        timeLeft = startTimeSeconds;
        isRunning = true;
    }
}