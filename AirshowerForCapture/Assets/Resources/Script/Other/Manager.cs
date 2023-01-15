using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    //透明オブジェクトの切り替え用スクリプトです
    //背景の切り替え用スクリプトから呼ばれます
    
    public static void delete(int flag)
    {
        if (flag == 1)
        {
            GameObject EarlyMorning = GameObject.Find("EarlyMorning");
            foreach (Transform item in EarlyMorning.transform)
            {
                item.gameObject.SetActive(false);
            }

            GameObject Noon = GameObject.Find("Noon");
            foreach (Transform item in Noon.transform)
            {
                item.gameObject.SetActive(true);
            }
        }

        else if (flag == 2)
        {
            GameObject Noon = GameObject.Find("Noon");
            foreach (Transform item in Noon.transform)
            {
                item.gameObject.SetActive(false);
            }

            GameObject Evening = GameObject.Find("Evening");
            foreach (Transform item in Evening.transform)
            {
                item.gameObject.SetActive(true);
            }
        }
        else if (flag == 3)
        {
            GameObject Evening = GameObject.Find("Evening");
            foreach (Transform item in Evening.transform)
            {
                item.gameObject.SetActive(false);
            }

            GameObject LaterEvening = GameObject.Find("LaterEvening");
            foreach (Transform item in LaterEvening.transform)
            {
                item.gameObject.SetActive(true);
            }
        }
        else if (flag == 4)
        {
            GameObject LaterEvening = GameObject.Find("LaterEvening");
            foreach (Transform item in LaterEvening.transform)
            {
                item.gameObject.SetActive(false);
            }

            GameObject EarlyMorning = GameObject.Find("EarlyMorning");
            foreach (Transform item in EarlyMorning.transform)
            {
                item.gameObject.SetActive(true);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
