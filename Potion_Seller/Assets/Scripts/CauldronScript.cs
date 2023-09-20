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

    public void processPotion()
    {
        player.GetComponent<RecipeSpawnerController>().removeCard(ingredients);
        
        ingredients = new IngredientScript.IngredientType[3];
        listIndex = 0;

    }
}
