using UnityEngine;

/// <summary> 
/// audio manager to handle sound effects
public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource buttonSFX;
    [SerializeField] private AudioSource scoreSFX;
    [SerializeField] private AudioSource losePointSFX;

    // Singleton instance
    static AudioManager Instance { get; set; }
    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    // Static methods to play sound effects
    public static void PlayButtonSFX()
    {
        if (Instance != null && Instance.buttonSFX != null)
        {
            Instance.buttonSFX.Play();
        }
        else
        {
            Debug.LogWarning("AudioManager or SFX not initialized");
        }
    }
    public static void PlayScoreSFX()
    {
        if (Instance != null && Instance.scoreSFX != null)
        {
            Instance.scoreSFX.Play();
        }
        else
        {
            Debug.LogWarning("AudioManager or SFX not initialized");
        }
    }
    public static void PlayErrorSFX()
    {
        if (Instance != null && Instance.losePointSFX != null)
        {
            Instance.losePointSFX.Play();
        }
        else
        {
            Debug.LogWarning("AudioManager or SFX not initialized");
        }
    }
}
