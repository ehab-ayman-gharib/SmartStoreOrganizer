using UnityEngine;

public class ProductItem : DraggableItem
{
    ProductData productData;
    void Start()
    {
        base.Initialize();
    }

    void Update()
    {

    }
    public void SetProductData(ProductData data)
    {
        productData = data;
    }
}
