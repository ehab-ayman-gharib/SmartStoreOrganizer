using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    [SerializeField] Button settingsBtn;
    [SerializeField] SettingsPanel settingsPanel;
    void Start()
    {
        Initialize();
    }

    void Update()
    {
        
    }
    // Show the settings button
    public void ShowSettingsBtn()
    {
        settingsBtn.gameObject.SetActive(true);
    }
    // Reset the settings panel to its default state
    public void Reset()
    {
        settingsPanel.Reset();
    }
    // Initialize the settings button functionality
    void Initialize()
    {
        settingsBtn.onClick.AddListener(() =>
        {
            settingsPanel.Show();
        });
    }
}
