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

    public void removeCard(int id)
    {
        if (id < 0)
        {
            Debug.LogWarning("no potion made");
            incorrectSFX.Play();
            return;
        }

        for (int i = 0; i < parent.transform.childCount; i++)
        {
            Debug.Log("checking recipe with id: " + parent.transform.GetChild(i).GetComponent<RecipeController>().recipeId);
            if(parent.transform.GetChild(i).GetComponent<RecipeController>().recipeId == id)
            {
                Debug.Log("deleting");
                parent.transform.GetChild(i).GetComponent<RecipeController>().isComplete = true;
                correctSFX.Play();
                return;
            }
        }

        incorrectSFX.Play();
    }
}
