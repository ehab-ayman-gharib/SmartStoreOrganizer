using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class ProductsManager : MonoBehaviour
{
    [SerializeField] ProductsDatabase productDatabase;
    [SerializeField] Transform[] productsPlaceholders;
    void Start()
    {
        if (productsPlaceholders.Length == 0)
        {
            Debug.LogError("No placeholders assigned in the Inspector.");
            return;
        }

        var products = productDatabase.products.ToList();
        if (products.Count < productsPlaceholders.Length)
        {
            Debug.LogError("Not enough products in the database.");
            return;
        }

        // Shuffle and pick 5 unique products
        var selected = products.OrderBy(x => Random.value).Take(productsPlaceholders.Length).ToList();

        for (int i = 0; i < selected.Count; i++)
        {
            Debug.Log($"Selected: {selected[i].productName} ({selected[i].category})");
            Instantiate(selected[i].productPrefab, productsPlaceholders[i].position, Quaternion.identity, productsPlaceholders[i]);
        }
    }

    void Update()
    {

    }
}
