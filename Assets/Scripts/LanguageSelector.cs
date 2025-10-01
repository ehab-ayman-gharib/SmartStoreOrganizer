using System.Collections;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

public class LanguageSelector : MonoBehaviour
{
    [System.Serializable]
    public struct LanguageButton
    {
        public Button langBtn;
        public Locale locale;
    }
    public LanguageButton[] languageButtons;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    IEnumerator Start()
    {
        yield return LocalizationSettings.InitializationOperation;
        foreach (var langBtn in languageButtons)
        {
            langBtn.langBtn.onClick.AddListener(() =>
         {
            SetLanguage(langBtn.locale);
         });
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SetLanguage(Locale locale)
    {
        LocalizationSettings.SelectedLocale = locale;
    }
}
