using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // an array of a enemy list
    // array at index 0, represent front of the ship
    // index 1, represent back
    // index 2, represent left
    // index 3, represent right
    private List<Enemy>[] enemies = new List<Enemy>[4];

    // setup the size of the board view
    [Header("Battleview Setting")]
    [SerializeField] private float leftBoundary;
    [SerializeField] private float rightBoundary;
    [SerializeField] private float topBoundary;
    [SerializeField] private float bottomBoundary;
    [SerializeField] private float minDistanceFromPlayer;
    [SerializeField] private float maxDistanceFromPlayer;


    [Header("Enemy Spawn")]
    // represent the initial amount of enemies in the start of the game in each side
    [SerializeField] private int initialEnemyAmount = 10;
    // after the enemy reached this amount, the game will not spawn new enemies
    [SerializeField] private int enemyTotalSpawn = 20;
    // the speed of spawning new enemy per second
    [SerializeField] private float enemySpawnSpeed = 0.5f;

    [Header("Enemy Prefab")]
    [SerializeField] private GameObject enemyDefault;

    // Start is called before the first frame update
    void Start()
    {
        // initialize enemies list
        InitializeEnemiesList();
    }

    private void InitializeEnemiesList()
    {
        // for 4 side of the game board
        for (int i = 0; i < 4; i++)
        {
            enemies[i] = new List<Enemy>();
            for (int a = 0; a < initialEnemyAmount; a++)
            {
                float x = Random.Range(leftBoundary, rightBoundary);
                float y = Random.Range(bottomBoundary, topBoundary);
                float z = Random.Range(minDistanceFromPlayer, maxDistanceFromPlayer);

                Enemy newEnemy = new Enemy(x, y, z);

                enemies[i].Add(newEnemy);
                Debug.Log(newEnemy.ToString());
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
