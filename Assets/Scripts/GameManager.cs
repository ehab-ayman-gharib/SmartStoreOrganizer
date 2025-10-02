using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; set; }
    [SerializeField] CountdownTimer countdownTimer;
    public ProductData.Category GameCategory;
    [HideInInspector]
    public bool menuDisplayed = false;
    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    void Start()
    {
        countdownTimer.OnTimerEnd += () =>
        {
            Debug.Log("Timer ended! Game Over!");
            // Handle game over logic here
        };
        if(menuDisplayed)
            StartGame();

    }
    public void StartGame()
    {
        Debug.Log("Game Started");
        menuDisplayed = true;
        countdownTimer.StartTimer();
    }

    void Update()
    {

    }
}
