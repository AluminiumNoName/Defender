using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSaver : MonoBehaviour
{
    public void ClearSaves()
    {
        ClearLvL();
        ClearCrystals();
        ClearHealth();
        ClearHealthGrade();
    }

    public static void SaveLvl()
    {
        PlayerPrefs.SetInt("lvl", LevelController.lvl);
    }  
    public static void SaveCrystals()
    {
        PlayerPrefs.SetInt("crystals", Corn.singleton.crystals);
    }

    public static void SaveHealth()
    {
        PlayerPrefs.SetInt("health", Corn.singleton.health);
    }

    public static void ClearHealth()
    {
        PlayerPrefs.SetInt("health", Corn.singleton.basicHealth);
    }

    public static void ClearLvL()
    {
        PlayerPrefs.SetInt("lvl", 1);
    }
    
    public static void ClearCrystals()
    {
        PlayerPrefs.SetInt("crystals", 0);
    }

  

    public static void ClearHealthGrade()
    {
        PlayerPrefs.SetInt("healthGrade", 0);
    }
}
