using UnityEngine;

public class DropTarget : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.GetComponent<DraggableItem>())
        {
            Debug.Log("Dropped on target!");
            // Call your trigger logic here
        }
    }
}
