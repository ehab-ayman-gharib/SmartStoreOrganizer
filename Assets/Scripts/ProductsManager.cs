using UnityEngine;

public class ProductsManager : MonoBehaviour
{
    [SerializeField] ProductsDatabase productDatabase; // Assign in Inspector
    [SerializeField] Transform[] productsPlaceholders; // Assign in Inspector
    void Start()
    {
        if (productsPlaceholders.Length == 0)
        {
            Debug.LogError("No placeholders assigned in the Inspector.");
            return;
        }
        foreach (var product in productDatabase.products)
        {
            Debug.Log(product.productName + " - $" + product.productName);
        }
    }

    void Update()
    {

    }
}
