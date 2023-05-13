using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgader : MonoBehaviour
{
    int upgPrice = 1;

    public Text healthPriceText;
    public void UpgradeHealth()
    {
        if(Corn.singleton.crystals >= upgPrice)
        {
        int healthGrade = PlayerPrefs.GetInt("healthGrade", 0);
        healthGrade++;
        PlayerPrefs.SetInt("healthGrade", healthGrade);
        Corn.singleton.TakeCrystals(upgPrice);
        }
        
    }


    void Update()
    {
        healthPriceText.text = upgPrice.ToString();
    }
}
