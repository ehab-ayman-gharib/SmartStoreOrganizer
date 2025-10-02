using UnityEngine;

public class UIPanel : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {

    }
    virtual public void Hide()
    {
        LeanTween.scale(gameObject, Vector3.zero, 0.7f)
                 .setEase(LeanTweenType.easeOutQuart);
    }
    virtual public void Show()
    {
        LeanTween.scale(gameObject, Vector3.one, 0.7f)
                 .setEase(LeanTweenType.easeOutBack); // adds a nice bounce
    }
    virtual public void Reset()
    {
        LeanTween.scale(gameObject, Vector3.zero, 0f)
                 .setEase(LeanTweenType.linear); // adds a nice bounce
    }
}
