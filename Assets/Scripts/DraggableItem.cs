using UnityEngine;

public class DraggableItem : MonoBehaviour
{
    private Vector3 offset;
    private Camera cam;
    private bool isDragging;

    void Start()
    {
        cam = Camera.main;
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

        transform.position = worldPos;
    }

    void OnMouseUp()
    {
        isDragging = false;
    }
}


