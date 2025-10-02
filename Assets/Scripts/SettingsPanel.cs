using UnityEngine;
using UnityEngine.UI;

// This script manages the settings panel UI
public class SettingsPanel : UIPanel
{
    // Reference to the close button
    [SerializeField] Button closeBtn;

    public override void Show()
    {
        base.Show();
    }
    public override void Reset()
    {
        base.Reset();
    }
    void Start()
    {
        Initialize();
    }

    void Update()
    {

    }

    // Initialize the close button functionality
    void Initialize()
    {
        if (closeBtn != null)
        {
            closeBtn.onClick.AddListener(() =>
            {
                Hide();
            });
        }
    }
}
