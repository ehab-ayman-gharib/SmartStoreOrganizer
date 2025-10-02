using UnityEngine;
using System.Linq;

public class ProductsTarget : MonoBehaviour
{
    [SerializeField] Transform[] targetPlaceholders;
    private Transform[] shuffledPlaceholders;
    private int currentIndex = 0;

    void Start()
    {
        // Shuffle placeholders at start
        shuffledPlaceholders = targetPlaceholders.OrderBy(x => Random.value).ToArray();
        currentIndex = 0;
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        var draggable = col.GetComponent<DraggableItem>();
        if (draggable != null && currentIndex < shuffledPlaceholders.Length)
        {
            Debug.Log("Dropped on target!");
            AudioManager.PlayScoreSFX();
            // Move the product to the next shuffled placeholder
            draggable.transform.position = shuffledPlaceholders[currentIndex].position;
            draggable.transform.rotation = shuffledPlaceholders[currentIndex].rotation;

            currentIndex++;
        }
    }
}
