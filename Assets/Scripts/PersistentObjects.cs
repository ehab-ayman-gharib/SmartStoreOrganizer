using UnityEngine;

public class PersistentObjects : MonoBehaviour
{
    private static PersistentObjects instance;

    // Ensure only one instance exists and persists across scenes
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {

    }
}
