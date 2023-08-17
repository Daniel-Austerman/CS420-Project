using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientScript : MonoBehaviour
{
    public string ingredientType;

    [SerializeField] private GameObject prefab;

    private bool checkingPickup;

    // Start is called before the first frame update
    void Start()
    {
        checkingPickup = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (checkingPickup && 
            (transform.Find("[RightHand Controller] Dynamic Attach") || transform.Find("[LeftHand Controller] Dynamic Attach")))
        {
            checkingPickup = false;
            Debug.Log("spawning: " + ingredientType);
            Invoke("SpawnIngredient", 1f);
        }

        
    }

    public void SpawnIngredient()
    {
        if (prefab != null)
            Instantiate(prefab);
    }
}
