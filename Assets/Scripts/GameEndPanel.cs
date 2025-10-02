using UnityEngine;
using UnityEngine.UI;


public class GameEndPanel : UIPanel
{
    // Reference to the close button
    [SerializeField] Button closeBtn;
    [SerializeField] GameObject winTxt;
    [SerializeField] GameObject loseTxt;

    public override void Show()
    {
        base.Show();
    }
    public void StartGameEndPanel(bool win)
    {
        Show();
        if(win)
        {
            winTxt.SetActive(true);
            // Handle win scenario
        }
        else
        {
            loseTxt.SetActive(true);
            // Handle lose scenario
        }

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
