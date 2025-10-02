using UnityEngine;
using System.Linq;

public class ProductsTarget : MonoBehaviour
{
    // Array of target placeholders for products
    [SerializeField] Transform[] targetPlaceholders;
    // Shuffled array of placeholders
    Transform[] shuffledPlaceholders;
    int currentIndex = 0;

    void Start()
    {
        Initialize();
    }

    void Update()
    {

    }
    // Handle product item entering the target area, checking category, and placing it correctly
    void OnTriggerEnter(Collider col)
    {
        var productItem = col.GetComponent<ProductItem>();
        if (productItem != null && currentIndex < shuffledPlaceholders.Length)
        {
            // Correct category, place the product
            if (productItem.GetProductData().category == GameManager.Instance.GameCategory)
            {
                AudioManager.PlayScoreSFX();
                // Move the product to the next shuffled placeholder
                productItem.transform.position = shuffledPlaceholders[currentIndex].position;
                productItem.transform.rotation = shuffledPlaceholders[currentIndex].rotation;
                productItem.OnItemCollected();
                currentIndex++;
                // Check if all items have been collected
                if (currentIndex == GameManager.Instance.totalItemsCountToCollect)
                {
                    Debug.Log("All items collected! You win!");
                    GameManager.Instance.WonGame();
                }
            }
            // Wrong category, reset position
            else
            {
                Debug.Log("Wrong category! Resetting position.");
                AudioManager.PlayErrorSFX();
                productItem.Reset();
            }
        }
    }
    // Initialize and shuffle target placeholders
    void Initialize()
    {
        shuffledPlaceholders = targetPlaceholders.OrderBy(x => Random.value).ToArray();
        currentIndex = 0;
    }
}
