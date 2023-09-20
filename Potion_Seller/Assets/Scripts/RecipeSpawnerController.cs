using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeSpawnerController : MonoBehaviour
{

    public GameObject recipe;
    public float timer;
    public float timerMin;
    public float timerMax;
    public float xSpawnPos;
    public float ySpawnPos;
    public float zSpawnPos;

    [SerializeField] private GameObject parent;

    [SerializeField] private AudioSource correctSFX;
    [SerializeField] private AudioSource incorrectSFX;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0.0f)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            timer = Random.Range(timerMin, timerMax);
            Instantiate(recipe, parent.transform);
            Debug.Log("New recipe spawned!");
        }
    }

    public void removeCard(IngredientScript.IngredientType[] ingredients)
    {    
        Debug.Log("entered recipe: " + ingredients[0] + ", " + ingredients[1] + ", " + ingredients[2]);
        
        for (int i = 0; i < parent.transform.childCount; i++)
        {
            Debug.Log("checking recipe: " + parent.transform.GetChild(i).GetComponent<RecipeController>().ingredients[0] + ", " 
                                          + parent.transform.GetChild(i).GetComponent<RecipeController>().ingredients[1] + ", " 
                                          + parent.transform.GetChild(i).GetComponent<RecipeController>().ingredients[2]);


            if (CheckArrays(parent.transform.GetChild(i).GetComponent<RecipeController>().ingredients, ingredients))
            {
                Debug.Log("deleting");
                parent.transform.GetChild(i).GetComponent<RecipeController>().isComplete = true;
                correctSFX.Play();
                return;
            }
        }

        incorrectSFX.Play();
    }

    public bool CheckArrays(IngredientScript.IngredientType[] array1, IngredientScript.IngredientType[] array2)
    {
        for (int x = 0; x < 3; x++)
        {
            if (array1[x] != array2[x])
            {
                return false;
            }
        }
        return true;
    }
}
