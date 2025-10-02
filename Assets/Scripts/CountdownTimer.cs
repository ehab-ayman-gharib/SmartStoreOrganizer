using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    // Starting time in seconds
    [SerializeField] float startTimeSeconds = 30f;
    [SerializeField] TextMeshProUGUI timerText;
    float timeLeft;
    bool isRunning = false;

    // Event triggered when the timer ends
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
            if(timeLeft > 9f)
                timerText.text = "00:" + Mathf.CeilToInt(timeLeft).ToString();
            else
                timerText.text = "00:0"+Mathf.CeilToInt(timeLeft).ToString();
        }
    }

    // Initialize the timer and UI
    void Initialize()
    {
        timeLeft = startTimeSeconds;
        if (timerText != null)
        {
            timerText.text = "00:" + Mathf.CeilToInt(timeLeft).ToString();
        }
    }

    // Start the countdown timer
    public void StartTimer()
    {
        timeLeft = startTimeSeconds;
        isRunning = true;
    }
    public void StopTimer()
    {
        isRunning = false;
    }
}