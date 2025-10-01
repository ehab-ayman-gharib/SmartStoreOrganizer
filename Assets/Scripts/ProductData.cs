using JetBrains.Annotations;
using System;
using UnityEngine;


[System.Serializable] // Needed to make it show up inside arrays
public class ProductData
{
    public enum Category
    {
        Cooler,
        Shelf
    }
    public string productName;
    public Category category;
    public GameObject productPrefab;
}