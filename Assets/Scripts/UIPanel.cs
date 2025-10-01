using UnityEngine;

public class UIPanel : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }
    virtual public void Hide()
    {
        LeanTween.scale(gameObject, Vector3.zero, 1f)
                 .setEase(LeanTweenType.easeInBack) // adds a nice bounce
                 .setOnComplete(() => Destroy(gameObject));
    }
    virtual public void Show()
    {
        LeanTween.scale(gameObject, Vector3.one, 1f)
                 .setEase(LeanTweenType.easeOutBack); // adds a nice bounce
    }
}
