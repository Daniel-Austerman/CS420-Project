using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauldronScript : MonoBehaviour
{
    public IngredientScript.IngredientType[] ingredients = new IngredientScript.IngredientType[3]; 
    private int listIndex;

    public GameObject player;

    public AudioSource splashSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        listIndex = 0;
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Ingredient")
        {
            if (listIndex < 3) {
                ingredients[listIndex] = collision.gameObject.GetComponent<IngredientScript>().ingredient;
                listIndex++;
            }

            splashSoundEffect.Play();

            collision.GetComponent<IngredientScript>().SpawnIngredient();
            Debug.Log("destroying " + collision.name);
            Destroy(collision.gameObject);
        }
    }

    public int potionCompile()
    {
        switch (ingredients[0])
        {
            case IngredientScript.IngredientType.Frog:
                switch (ingredients[1])
                {
                    case IngredientScript.IngredientType.Frog:
                        switch (ingredients[2])
                        {
                            case IngredientScript.IngredientType.Frog:
                                return 6;
                            case IngredientScript.IngredientType.Leaves:
                                return 7;
                            case IngredientScript.IngredientType.Feather:
                                break;
                            default:
                                return 0;
                        }
                        break;
                    case IngredientScript.IngredientType.Leaves:
                        switch (ingredients[2])
                        {
                            case IngredientScript.IngredientType.Frog:
                                break;
                            case IngredientScript.IngredientType.Leaves:
                                break;
                            case IngredientScript.IngredientType.Feather:
                                return 8;
                            default:
                                return 1;
                        }
                        break;
                    case IngredientScript.IngredientType.Feather:
                        switch (ingredients[2])
                        {
                            case IngredientScript.IngredientType.Frog:
                                break;
                            case IngredientScript.IngredientType.Leaves:
                                break;
                            case IngredientScript.IngredientType.Feather:
                                return 9;
                            default:
                                return 3;
                        }
                        break;
                }
                break;
            case IngredientScript.IngredientType.Leaves:
                switch (ingredients[1])
                {
                    case IngredientScript.IngredientType.Frog:
                        switch (ingredients[2])
                        {
                            case IngredientScript.IngredientType.Frog:
                                break;
                            case IngredientScript.IngredientType.Leaves:
                                break;
                            case IngredientScript.IngredientType.Feather:
                                break;
                            default:
                                break;
                        }
                        break;
                    case IngredientScript.IngredientType.Leaves:
                        switch (ingredients[2])
                        {
                            case IngredientScript.IngredientType.Frog:
                                break;
                            case IngredientScript.IngredientType.Leaves:
                                break;
                            case IngredientScript.IngredientType.Feather:
                                break;
                            default:
                                return 2;
                        }
                        break;
                    case IngredientScript.IngredientType.Feather:
                        switch (ingredients[2])
                        {
                            case IngredientScript.IngredientType.Frog:
                                break;
                            case IngredientScript.IngredientType.Leaves:
                                break;
                            case IngredientScript.IngredientType.Feather:
                                break;
                            default:
                                return 4;
                        }
                        break;
                }
                break;
            case IngredientScript.IngredientType.Feather:
                switch (ingredients[1])
                {
                    case IngredientScript.IngredientType.Frog:
                        switch (ingredients[2])
                        {
                            case IngredientScript.IngredientType.Frog:
                                break;
                            case IngredientScript.IngredientType.Leaves:
                                break;
                            case IngredientScript.IngredientType.Feather:
                                break;
                            default:
                                break;
                        }
                        break;
                    case IngredientScript.IngredientType.Leaves:
                        switch (ingredients[2])
                        {
                            case IngredientScript.IngredientType.Frog:
                                break;
                            case IngredientScript.IngredientType.Leaves:
                                break;
                            case IngredientScript.IngredientType.Feather:
                                break;
                            default:
                                break;
                        }
                        break;
                    case IngredientScript.IngredientType.Feather:
                        switch (ingredients[2])
                        {
                            case IngredientScript.IngredientType.Frog:
                                break;
                            case IngredientScript.IngredientType.Leaves:
                                break;
                            case IngredientScript.IngredientType.Feather:
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
        ingredients = new IngredientScript.IngredientType[3];
        listIndex = 0;

        Debug.Log("Made potion " + potion);
        player.GetComponent<RecipeSpawnerController>().removeCard(potion);
    }
}
