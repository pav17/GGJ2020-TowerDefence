using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public List<EnemyScript> enemies;

    // Start is called before the first frame update
    void Start()
    {
        enemies = new List<EnemyScript>();
        enemies.AddRange(GameObject.FindObjectsOfType<EnemyScript>());
    }

    // Update is called once per frame
    void Update()
    {
        GetEnemies();
        ProcessEnemies();
    }

    void GetEnemies()
    {
        enemies = new List<EnemyScript>();
        enemies.AddRange(GameObject.FindObjectsOfType<EnemyScript>());
    }

    void ProcessEnemies()
    {
        foreach (EnemyScript enemy in enemies)
        {
            if (enemy.ready_to_delete)
            {
                GameObject.Destroy(enemy);
                ProcessEnemyDrop();
            }
        }
    }

    void ProcessEnemyDrop()
    {
        Debug.Log("Ow!");
    }
}
