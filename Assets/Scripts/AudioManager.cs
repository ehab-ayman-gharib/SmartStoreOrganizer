using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource buttonSFX;
    static AudioManager Instance { get; set; }
    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    void Start()
    {

    }

    void Update()
    {

    }
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
}
