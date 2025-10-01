using UnityEngine;

[CreateAssetMenu(fileName = "Product Database", menuName = "Products Database/Products Database")]
public class ProductsDatabase : ScriptableObject
{
    public ProductData[] products;
}