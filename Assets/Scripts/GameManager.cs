using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singleton instance
    public static GameManager Instance { get; set; }
    // Reference to the countdown timer
    [SerializeField] CountdownTimer countdownTimer;
    // Reference to the settings manager
    SettingsManager settingsManager;
    // Game category
    public ProductData.Category GameCategory;
    [HideInInspector]
    public static bool menuDisplayed = false;
    [HideInInspector]
    public bool GameStarted;
    // Reference to the game end panel
    [SerializeField] GameEndPanel gameEndPanel;
    public int totalItemsCountToCollect;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    void Start()
    {
        Initialize();
    }

    // Starting the game
    public void StartGame()
    {
        Debug.Log("Game Started");
        menuDisplayed = true;
        GameStarted = true;
        countdownTimer.StartTimer();
        settingsManager.ShowSettingsBtn();
    }

    // Initialize game components and event handlers
    void Initialize()
    {
        settingsManager = FindFirstObjectByType<SettingsManager>();
        settingsManager.Reset();
        countdownTimer.OnTimerEnd += () =>
        {
            Debug.Log("Timer ended! Game Over!");
            GameStarted = false;
            // Handle game over logic here
            gameEndPanel.StartGameEndPanel(false);
        };
        if (menuDisplayed)
            StartGame();
    }
    public void WonGame()
    {
        countdownTimer.StopTimer();
        GameStarted = false;
        // Handle game win logic here
        gameEndPanel.StartGameEndPanel(true);
        totalItemsCountToCollect = 0;

    }

}
