using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnSpots;

    private float timeBtwSpawns;

    public float startTimeBtwSpawns;

    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.score == 25)
        {
            startTimeBtwSpawns = 1.5f;
        } else if(player.score == 50)
        {
            startTimeBtwSpawns = 1.0f;
        } else if (player.score == 50)
        {
            startTimeBtwSpawns = 0.5f;
        }
        if (timeBtwSpawns <= 0)
        {
            int randPos = Random.Range(0, spawnSpots.Length);
            Instantiate(enemy, spawnSpots[randPos].position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
