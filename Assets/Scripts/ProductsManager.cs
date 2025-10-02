using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class ProductsManager : MonoBehaviour
{
    [SerializeField] ProductsDatabase productDatabase;
    [SerializeField] Transform[] productsPlaceholders;
    void Start()
    {
        InitializeProducts();
    }
    void InitializeProducts()
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

        // Split products by sceneCategory and other category
        var mainCategoryProducts = products.Where(p => p.category == GameManager.Instance.GameCategory).OrderBy(_ => Random.value).ToList();
        var otherCategoryProducts = products.Where(p => p.category != GameManager.Instance.GameCategory).OrderBy(_ => Random.value).ToList();

        int half = productsPlaceholders.Length / 2 + productsPlaceholders.Length % 2;
        List<ProductData> selected = new();

        selected.AddRange(mainCategoryProducts.Take(half));
        selected.AddRange(otherCategoryProducts.Take(productsPlaceholders.Length - half));


        // Shuffle the final selection
        selected = selected.OrderBy(x => Random.value).ToList();

        for (int i = 0; i < selected.Count; i++)
        {
            Instantiate(selected[i].productPrefab, productsPlaceholders[i].position, Quaternion.identity, productsPlaceholders[i]);
        }

    }
    void Update()
    {

    }
}
