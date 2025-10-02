using UnityEngine;

public class ProductItem : DraggableItem
{
    ProductData productData;
    Vector3 initialPos;
    bool isPlaced = false;
    void Start()
    {
        base.Initialize();
        initialPos = transform.position;
    }

    void Update()
    {

    }
    public void SetProductData(ProductData data)
    {
        productData = data;
    }
    public ProductData GetProductData()
    {
        return productData;
    }

    // Handle collision with floor or podium to reset position
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Floor") || other.CompareTag("Podium"))
        {
            Debug.Log("Obstacle Hit");
            Reset();
        }
    }

    // Override to prevent dragging if the game hasn't started or the item is already placed
    public override void OnMouseDown()
    {
        if (GameManager.Instance.GameStarted && !isPlaced)
            base.OnMouseDown();
    }
    public void Reset()
    {
        isDragging = false;
        transform.position = initialPos;

    }
    // Called when the item is successfully placed in the target area to mark it as collected
    public void OnItemCollected()
    {
        isPlaced = true;
        isDragging = false;
    }
}
