using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientScript : MonoBehaviour
{
    public enum IngredientType
    {
        Frog,
        Leaves,
        Feather,
        Elixer,
        Flower
    };

    public IngredientType ingredient;

    [SerializeField] private GameObject prefab;
    [SerializeField] private Vector3 spawnPos;

    private bool checkingPickup;

    // Start is called before the first frame update
    void Start()
    {
        checkingPickup = true;
    }

    public void SpawnIngredient()
    {
        if (prefab != null)
            Instantiate(prefab, spawnPos, Quaternion.identity);
    }
}
