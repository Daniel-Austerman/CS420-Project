using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeController : MonoBehaviour
{

    public int recipeId;
    public int ingredient1Id;
    public int ingredient2Id;
    public int ingredient3Id;
    public bool isComplete = false;

    // Start is called before the first frame update
    void Start()
    {
        float randomValue = Random.value * 10;
        if (randomValue < 1)
        {
            recipeId = 0;
            ingredient1Id = 1;
            ingredient2Id = 1;
            ingredient3Id = 0;
        } else if (randomValue > 1 && randomValue < 2)
        {
            recipeId = 1;
            ingredient1Id = 1;
            ingredient2Id = 2;
            ingredient3Id = 0;
        } else if (randomValue > 2 && randomValue < 3)
        {
            recipeId = 2;
            ingredient1Id = 2;
            ingredient2Id = 2;
            ingredient3Id = 0;
        } else if (randomValue > 3 && randomValue < 4)
        {
            recipeId = 3;
            ingredient1Id = 1;
            ingredient2Id = 3;
            ingredient3Id = 0;
        } else if (randomValue > 4 && randomValue < 5)
        {
            recipeId = 4;
            ingredient1Id = 2;
            ingredient2Id = 3;
            ingredient3Id = 0;
        } else if (randomValue > 5 && randomValue < 6)
        {
            recipeId = 5;
            ingredient1Id = 3;
            ingredient2Id = 3;
            ingredient3Id = 0;
        } else if (randomValue > 6 && randomValue < 7)
        {
            recipeId = 6;
            ingredient1Id = 1;
            ingredient2Id = 1;
            ingredient3Id = 1;
        } else if (randomValue > 7 && randomValue < 8)
        {
            recipeId = 7;
            ingredient1Id = 1;
            ingredient2Id = 1;
            ingredient3Id = 2;
        } else if (randomValue > 8 && randomValue < 9)
        {
            recipeId = 8;
            ingredient1Id = 1;
            ingredient2Id = 2;
            ingredient3Id = 3;
        } else if (randomValue > 9 && randomValue <= 10)
        {
            recipeId = 9;
            ingredient1Id = 1;
            ingredient2Id = 3;
            ingredient3Id = 3;
        } else
        {
            Debug.Log("ERROR IN RANDOM VALUE");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isComplete)
        {
            Destroy(this.gameObject);
        }
    }
}
