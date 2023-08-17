using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauldronScript : MonoBehaviour
{

    public string[] ingredients = new string[3];
    //public int[] ingredientCounts = new int[3];

    private int listIndex;

    public GameObject player;

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
            if (listIndex < 3) {
                ingredients[listIndex] = collision.gameObject.GetComponent<IngredientScript>().ingredientType;
                listIndex++;
            }

            collision.GetComponent<IngredientScript>().SpawnIngredient();
            Debug.Log("destroying " + collision.name);
            Destroy(collision.gameObject);
        }
    }

    public int potionCompile()
    {
        switch (ingredients[0])
        {
            case "cube":
                switch (ingredients[1])
                {
                    case "cube":
                        switch (ingredients[2])
                        {
                            case "cube":
                                return 6;
                            case "cylin":
                                return 7;
                            case "pyram":
                                break;
                            default:
                                return 0;
                        }
                        break;
                    case "cylin":
                        switch (ingredients[2])
                        {
                            case "cube":
                                break;
                            case "cylin":
                                break;
                            case "pyram":
                                return 8;
                            default:
                                return 1;
                        }
                        break;
                    case "pyram":
                        switch (ingredients[2])
                        {
                            case "cube":
                                break;
                            case "cylin":
                                break;
                            case "pyram":
                                return 9;
                            default:
                                return 3;
                        }
                        break;
                }
                break;
            case "cylin":
                switch (ingredients[1])
                {
                    case "cube":
                        switch (ingredients[2])
                        {
                            case "cube":
                                break;
                            case "cylin":
                                break;
                            case "pyram":
                                break;
                            default:
                                break;
                        }
                        break;
                    case "cylin":
                        switch (ingredients[2])
                        {
                            case "cube":
                                break;
                            case "cylin":
                                break;
                            case "pyram":
                                break;
                            default:
                                return 2;
                        }
                        break;
                    case "pyram":
                        switch (ingredients[2])
                        {
                            case "cube":
                                break;
                            case "cylin":
                                break;
                            case "pyram":
                                break;
                            default:
                                return 4;
                        }
                        break;
                }
                break;
            case "pyram":
                switch (ingredients[1])
                {
                    case "cube":
                        switch (ingredients[2])
                        {
                            case "cube":
                                break;
                            case "cylin":
                                break;
                            case "pyram":
                                break;
                            default:
                                break;
                        }
                        break;
                    case "cylin":
                        switch (ingredients[2])
                        {
                            case "cube":
                                break;
                            case "cylin":
                                break;
                            case "pyram":
                                break;
                            default:
                                break;
                        }
                        break;
                    case "pyram":
                        switch (ingredients[2])
                        {
                            case "cube":
                                break;
                            case "cylin":
                                break;
                            case "pyram":
                                break;
                            default:
                                return 5;
                        }
                        break;
                }
                break;
        }
        return -1;
    }

    public void processPotion()
    {
        int potion = potionCompile();
        ingredients = new string[3];
        listIndex = 0;

        Debug.Log("Made potion " + potion);
        player.GetComponent<RecipeSpawnerController>().removeCard(potion);
    }
}
