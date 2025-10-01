using System.Collections;
using UnityEngine;

public class GameMenu : UIPanel
{
    public override void Show()
    {
        base.Show();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    IEnumerator Start()
    {
        yield return new WaitForSeconds(1f);
        Show();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
