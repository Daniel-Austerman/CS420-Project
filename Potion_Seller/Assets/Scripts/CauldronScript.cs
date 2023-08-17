using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauldronScript : MonoBehaviour
{

    public string[] ingredients = new string[3];
    public int[] ingredientCounts = new int[3];

    private int listIndex;

    // Start is called before the first frame update
    void Start()
    {
        listIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Ingredient")
        {
            if (ingredientCounts[listIndex] == 0)
            {
                ingredients[listIndex] = collision.gameObject.GetComponent<IngredientScript>().ingredientType;
                ingredientCounts[listIndex]++;
            }

            else if (ingredients[listIndex] == collision.gameObject.GetComponent<IngredientScript>().ingredientType)
            {
                ingredientCounts[listIndex]++;
            }
            else
            {
                listIndex++;
                ingredients[listIndex] = collision.gameObject.GetComponent<IngredientScript>().ingredientType;
                ingredientCounts[listIndex]++;
            }

            Destroy(collision.gameObject);
        }
    }
}
