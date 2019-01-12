using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCookieScript : MonoBehaviour
{
    public static int CookieIncrement = 0;
    public int InternalCookieIncrement;
    public bool Creating = false;
    void Update()
    {
        InternalCookieIncrement = CookieIncrement;
        if (!Creating)
        {
            Creating = true;
            StartCoroutine(CreateCookie());
        }


    }

    private IEnumerator CreateCookie()
    {
        MainValues.CookieCount += CookieIncrement;
        yield return new WaitForSeconds(1);
        Creating = false;
    }
}
