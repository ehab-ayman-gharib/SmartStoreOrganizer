using System.Collections;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

// This script manages language selection in the game
public class LanguageSelector : MonoBehaviour
{
    // Struct to hold a button and its associated locale
    [System.Serializable]
    public struct LanguageButton
    {
        public Button langBtn;
        public Locale locale;
    }
    public LanguageButton[] languageButtons;
    IEnumerator Start()
    {
        yield return LocalizationSettings.InitializationOperation;
        InitializeLanguageButtons();
    }

    // Update is called once per frame
    void Update()
    {

    }
    // Set the selected language
    void SetLanguage(Locale locale)
    {
        LocalizationSettings.SelectedLocale = locale;
    }

    // Initialize the language buttons with their respective locales
    void InitializeLanguageButtons()
    {
        foreach (var langBtn in languageButtons)
        {
            langBtn.langBtn.onClick.AddListener(() =>
            {
                SetLanguage(langBtn.locale);
                AudioManager.PlayButtonSFX();
            });
        }

    }
}
