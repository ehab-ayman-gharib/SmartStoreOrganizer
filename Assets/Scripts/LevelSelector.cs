using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    [System.Serializable]
    public struct LevelSelectionBtn
    {
        public string levelName;
        public Button levelBtn;
    }
    public LevelSelectionBtn[] levelSelectionBtns;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
