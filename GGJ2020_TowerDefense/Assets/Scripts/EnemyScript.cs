using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int health;
    public float speed;
    public List<Effect> effects;
    public bool ready_to_delete;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessEffects();
    }

    public void ProcessEffects()
    {
        foreach (Effect enemy_effect in effects)
        {
            enemy_effect.ProcessEffect();
            if (enemy_effect.ready_to_delete)
            {
                effects.Remove(enemy_effect);
            }
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0f)
        {
            ready_to_delete = true;
        }
    }
}
