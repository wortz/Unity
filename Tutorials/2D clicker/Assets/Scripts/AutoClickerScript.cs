using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoClickerScript : MonoBehaviour
{
    public GameObject AutoObject;
    public GameObject statusBox;

    public void PurchaseClicker()
    {
        if (MainValues.MoneyCount > 0)
        {
            AutoObject.SetActive(true);
            AutoCookieScript.CookieIncrement += 1;
            MainValues.MoneyCount -= 1;
        }
        else
        {
            statusBox.GetComponent<Text>().text = "Not enough money to buy!";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
    }
}
