using UnityEngine;

public class DraggableItem : MonoBehaviour
{
    private Vector3 offset;
    private Camera cam;
    public bool isDragging;

    void Start()
    {

    }

    public virtual void Initialize()
    {
        cam = Camera.main;
        // Optional: Add any update logic here
    }
    void OnMouseDown()
    {
        isDragging = true;
        Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        offset = transform.position - new Vector3(mousePos.x, mousePos.y, transform.position.z);
    }

    void OnMouseDrag()
    {
        if (!isDragging) return;
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = cam.WorldToScreenPoint(transform.position).z; // keep correct depth
        Vector3 worldPos = cam.ScreenToWorldPoint(mousePos);
        worldPos.z = transform.position.z; // Keep original z if needed

        transform.position = worldPos;
    }

    void OnMouseUp()
    {
        isDragging = false;
    }
}


