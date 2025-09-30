using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.UI;

public class LanguageSelection : MonoBehaviour
{
    [System.Serializable]
    public struct LanguageButton
    {
        public Locale locale; // e.g., "en", "fr", "de"
        public Button button;  // e.g., "English", "Spanish"
    }

    public LanguageButton[] languageButtons;
}
