using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour
{
    // Tower components
    public GameController game_controller;
    public GameObject tower_base;
    public GameObject tower_turret;
    public GameObject tower_core;

    // Tower stats
    private float shot_rate;
    public float shot_rate_base;
    private float shot_radius;
    public float shot_radius_base;

    // Control variables
    private IEnumerator tower_fire;
    private bool is_active;
    private bool first_frame;

    // Start is called before the first frame update
    void Start()
    {
        is_active = true;
        first_frame = true;
        game_controller = GameObject.FindObjectOfType<GameController>();

        shot_rate = shot_rate_base;
        shot_radius = shot_radius_base;

        tower_fire = TowerFire();
    }

    // Update is called once per frame
    void Update()
    {
        if (first_frame)
        {
            first_frame = false;
            StartCoroutine(tower_fire);
        }
    }

    private IEnumerator TowerFire()
    {
        while (is_active)
        {
            if (game_controller.enemies.Count > 0)
            {
                foreach (EnemyScript enemy in game_controller.enemies)
                {
                    if (Vector3.Distance(transform.position, enemy.transform.position) <= shot_radius)
                    {
                        Debug.Log("FIRE");
                        yield return new WaitForSeconds(shot_rate);
                    }
                }
            }
        }
    }
}
