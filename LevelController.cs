using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public Spawner spawner;

    // Update is called once per frame
    void Update()
    {
        Check();
    }

    //check how lvl is doing
    void Check()
    {
        if (spawner.spawnCount <= 0)
        {
            Enemy[] enemies = FindObjectsOfType<Enemy>();
            if (enemies.Length == 0)
            {
                Victory();
            }
            if (Corn.singleton.health <= 0)
            {
                Defeat();
            }
        }
    }
    
    void Victory()
    {
        Debug.Log("You win");
    }
    void Defeat()
    {
        Debug.Log("You dead");
    }
}
