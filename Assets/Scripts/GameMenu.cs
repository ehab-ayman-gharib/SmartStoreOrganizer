using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameMenu : UIPanel
{
    [SerializeField] private Button startBtn;
    public override void Show()
    {
        base.Show();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    IEnumerator Start()
    {
        yield return new WaitForSeconds(1f);
        if(startBtn != null)
            startBtn.onClick.AddListener(() => {
                Hide();
            });

        Show();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
