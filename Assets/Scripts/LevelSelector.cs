using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
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
       // DontDestroyOnLoad(gameObject);
        InitializeLevelsBtns();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void InitializeLevelsBtns()
    {
        foreach (var levelBtn in levelSelectionBtns)
        {
            levelBtn.levelBtn.onClick.AddListener(() =>
            {
                StartCoroutine(LoadAsync(levelBtn.levelName));
            });
        }
    }
    private IEnumerator LoadAsync(string sceneName)
    {
        if (sceneName != SceneManager.GetActiveScene().name)
        {
            AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

            // Optional: show loading UI
            while (!operation.isDone)
            {
                float progress = Mathf.Clamp01(operation.progress / 0.9f);
                Debug.Log("Loading progress: " + (progress * 100) + "%");
                yield return null;
            }
        }
    }
}
