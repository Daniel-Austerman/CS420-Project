using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeController : MonoBehaviour
{

    public int recipeId;
    public IngredientScript.IngredientType[] ingredients = new IngredientScript.IngredientType[3];
    public int ingredient1Id;
    public int ingredient2Id;
    public int ingredient3Id;
    public bool isComplete = false;

    // Start is called before the first frame update
    void Start()
    {
        ingredient1Id = Mathf.FloorToInt(Random.value * 5);
        ingredient2Id = Mathf.FloorToInt(Random.value * 5);
        ingredient3Id = Mathf.FloorToInt(Random.value * 5);

        ingredients[0] = (IngredientScript.IngredientType) ingredient1Id;
        ingredients[1] = (IngredientScript.IngredientType) ingredient2Id;
        ingredients[2] = (IngredientScript.IngredientType) ingredient3Id;
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
