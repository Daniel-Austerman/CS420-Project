using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecipeTextController : MonoBehaviour
{

    public RecipeController recipeController;
    public TextMeshPro textMeshPro;
    public string ingredient1Name;
    public string ingredient2Name;
    public string ingredient3Name;

    // Start is called before the first frame update
    void Start()
    {
        recipeController = this.GetComponentInParent<RecipeController>();
        textMeshPro = this.GetComponent<TextMeshPro>();
        ingredient1Name = getIngredientName(recipeController.ingredient1Id);
        ingredient2Name = getIngredientName(recipeController.ingredient2Id);
        ingredient3Name = getIngredientName(recipeController.ingredient3Id);
        string fullText = ("Recipe\n" + ingredient1Name + "\n" + ingredient2Name + "\n" + ingredient3Name);
        textMeshPro.text = fullText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string getIngredientName(int id)
    {
        switch (id)
        {
            case 0:
                return "Toad";
            case 1:
                return "Leaves";
            case 2:
                return "Feather";
            case 3:
                return "Elixir";
            case 4:
                return "Flower";
            default:
                return "ERROR";
        }
    }
}
