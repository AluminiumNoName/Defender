using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corn : MonoBehaviour
{
    public static Corn singleton;
    public int health;
    //4lesson
    public int crystals;

    public int basicHealth;
    public int healthPerUpgrade;

    private void Awake()
    {
        singleton = this;
        //4lesson
        int healthBonus = healthPerUpgrade*PlayerPrefs.GetInt("healthGrade",0);
        health = basicHealth+healthBonus;
        crystals = PlayerPrefs.GetInt("crystals", 0);
    }

    public void TakeDamage()
    {
        if (health > 0)
        {
        health -= 1;

        }
    }
    //4lesson
    public void AddCrystals(int count)
    {
        crystals += count;
        GameSaver.SaveCrystals();
    }
    //4lesson
    public void TakeCrystals(int count)
    {
        crystals -= count;
        GameSaver.SaveCrystals();
    }

}



