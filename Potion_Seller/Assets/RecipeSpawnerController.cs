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
            Instantiate(recipe, new Vector3(xSpawnPos, ySpawnPos, zSpawnPos), Quaternion.identity);
            Debug.Log("New recipe spawned!");
        }
    }
}
