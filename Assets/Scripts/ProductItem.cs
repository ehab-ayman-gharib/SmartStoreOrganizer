using UnityEngine;

public class ProductItem : DraggableItem
{
    ProductData productData;
    Vector3 initialPos;
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
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Floor"))
        {
            Debug.Log("Floor Hit");
            isDragging = false;
            transform.position = initialPos;
        }
    }
}
