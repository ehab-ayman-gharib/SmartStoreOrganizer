using UnityEngine;

/// <summary>
/// Parent class for draggable items
public class DraggableItem : MonoBehaviour
{
    // Offset between mouse position and object position
    private Vector3 offset;
    // Reference to the main camera
    private Camera cam;
    // Flag to indicate if the item is being dragged
    public bool isDragging;


    // Initialize references
    public virtual void Initialize()
    {
        cam = Camera.main;
    }
    // Called when the mouse button is pressed down on the item to start dragging
    public virtual void OnMouseDown()
    {
        isDragging = true;
        Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        offset = transform.position - new Vector3(mousePos.x, mousePos.y, transform.position.z);
    }

    // Called while the mouse is held down to drag the item
    void OnMouseDrag()
    {
        if (!isDragging) return;
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = cam.WorldToScreenPoint(transform.position).z; 
        Vector3 worldPos = cam.ScreenToWorldPoint(mousePos);
        worldPos.z = transform.position.z; 
        transform.position = worldPos;
    }

    // Called when the mouse button is released to stop dragging
    void OnMouseUp()
    {
        isDragging = false;
    }
}


