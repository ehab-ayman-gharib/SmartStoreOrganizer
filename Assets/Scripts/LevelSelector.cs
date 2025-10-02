using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// This script manages level selection in the game
public class LevelSelector : MonoBehaviour
{
    [System.Serializable]
    public struct LevelSelectionBtn
    {
        public string levelName;
        public Button levelBtn;
    }
    public LevelSelectionBtn[] levelSelectionBtns;

    void Start()
    {
        InitializeLevelsBtns();
    }

    void Update()
    {

    }
    void InitializeLevelsBtns()
    {
        foreach (var levelBtn in levelSelectionBtns)
        {
            levelBtn.levelBtn.onClick.AddListener(() =>
            {
                AudioManager.PlayButtonSFX();
                StartCoroutine(LoadAsync(levelBtn.levelName));
            });
        }
    }
    private IEnumerator LoadAsync(string sceneName)
    {
        if (sceneName != SceneManager.GetActiveScene().name)
        {
            AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
            while (!operation.isDone)
            {
                float progress = Mathf.Clamp01(operation.progress / 0.9f);
                Debug.Log("Loading progress: " + (progress * 100) + "%");
                yield return null;
            }
        }
    }
}
