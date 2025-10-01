using UnityEngine;

[CreateAssetMenu(fileName = "Product Database", menuName = "Products Database/Product Database")]
public class ProductDatabase : ScriptableObject
{
    public ProductData[] products;
}