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
    private bool is_active;

    // Start is called before the first frame update
    void Start()
    {
        is_active = true;
        game_controller = GameObject.FindObjectOfType<GameController>();

        shot_rate = shot_rate_base;
        shot_radius = shot_radius_base;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
