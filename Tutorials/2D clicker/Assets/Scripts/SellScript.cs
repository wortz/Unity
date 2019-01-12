using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellScript : MonoBehaviour
{
    public GameObject statusBox;

    public void ButtonClicked()
    {
        if (MainValues.CookieCount > 0)
        {
            MainValues.CookieCount -= 1;
            MainValues.MoneyCount += 1;
        }
        else
        {
            statusBox.GetComponent<Text>().text = "Not enough cookies to sell";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
    }
}
