using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainValues : MonoBehaviour
{
    public static int CookieCount;
    public static int MoneyCount;
    public GameObject CookieDisplay;
    public GameObject MoneyDisplay;
    public int InternalMoney;
    public int InternalCookie;

    void Update(){
        InternalCookie = CookieCount;
        InternalMoney = MoneyCount;
        CookieDisplay.GetComponent<Text>().text = "Cookie:  " + InternalCookie;
        MoneyDisplay.GetComponent<Text>().text = "Money:  " + InternalMoney + "$";
    }
}
