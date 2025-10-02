using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameMenu : UIPanel
{
    // Reference to the start button
    [SerializeField] private Button startBtn;
    public override void Show()
    {
        base.Show();
    }

   
    IEnumerator Start()
    {
        yield return new WaitForSeconds(0.5f);
        ShowAndInitializeGameMenu();
    }

    // Shows the game menu and initializes the start button
    void ShowAndInitializeGameMenu()
    {
        if (startBtn != null)
            startBtn.onClick.AddListener(() => {
                Hide();
                AudioManager.PlayButtonSFX();
                GameManager.Instance.StartGame();
            });
        Show();
    }
}
