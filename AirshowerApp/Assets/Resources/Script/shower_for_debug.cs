using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class shower_for_debug : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("coroutineR");
    }

    void Update()
    {

    }

    // Update is called once per frame
    private IEnumerator coroutineR()
    {
        for (int i = 0; i < 1000; i++)
        {
            Effect.ShowerAdd(53f, 16.71f, 57.53f, 0, 15, 40, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(20f, 16.71f, 65.53f, 0, -20, 40, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(-5f, 16.71f, 77.53f, 0, -20, 40, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(49f, 15.71f, -70.7f, 0, 90, 50, "quest2_showerLL", 46, 60);//西
            Effect.ShowerAdd(72f, 5.71f, 33.53f, 0, 30, 7, "quest2_showerLLL", 23, 30);//南
            Effect.ShowerAdd(-30f, 1.71f, -60.7f, 0, 0, -20, "quest2_showerLLL", 23, 30);//北西
            Effect.ShowerAdd(-60f, 2.71f, 30.53f, 0, -30, -30, "quest2_showerLLL", 23, 30);//北東
                                                                                           //Effect.ShowerAdd(-35, 28, -70, 0, 25, -20, "quest2_showerL", 105, 105);//北西
            Effect.ShowerAdd(39f, 3.71f, -63.53f, 0, -30, -10, "quest2_showerLLL", 23, 30);//西
            Effect.ShowerAdd(-40.5f, 3.91f, -50.7f, 0, 0, 30, "quest2_showerLLL", 23, 30);//北西
            Effect.ShowerAdd(-4f, 7.71f, 80.53f, 0, -30, -30, "quest2_showerLLL", 23, 30);//北東
            Effect.ShowerAdd(30f, 20.71f, -75.7f, 0, -40, 40, "quest2_showerLL", 46, 60);//西 
            Effect.ShowerAdd(-75f, 11.71f, 37.53f, 0, -30, -13, "quest2_showerLL", 46, 60);//北東
            Effect.ShowerAdd(30f, 20.71f, -75.7f, 0, -40, 40, "quest2_showerLL", 46, 60);//西 
            Effect.ShowerAdd(72f, 5.71f, 27.7f, 0, 40, 10, "quest2_showerLL", 46, 60);//西 
                                                                                      //Effect.ShowerAdd(55.33f, 33.28f, 16.2f, 0, 70, -19, "quest2_showerL", 137, 137);//南（5kmの基準）
            Effect.ShowerAdd(39f, 3.71f, -63.53f, 0, -30, 10, "quest2_showerLLL", 23, 30);//西
            Effect.ShowerAdd(-40.5f, 3.91f, -50.7f, 0, 0, -10, "quest2_showerLLL", 23, 30);//北西
            Effect.ShowerAdd(-4f, 7.71f, 80.53f, 0, -30, 25, "quest2_showerLLL", 23, 30);//北東
            Effect.ShowerAdd(79f, 5.91f, 23.53f, 0, 30, 30, "quest2_showerLLL", 23, 30);//南
            Effect.ShowerAdd(37.5f, 4.91f, -69.7f, 0, 0, 0, "quest2_showerLLL", 23, 30);//西
            Effect.ShowerAdd(-9f, 5.71f, 80.53f, 0, -30, 0, "quest2_showerLLL", 23, 30);//東
            Effect.ShowerAdd(-45f, 18.41f, 67.53f, 0, -160, -25, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(45f, 10.71f, -66.7f, 0, -40, -17, "quest2_showerLL", 46, 60);//西

            Effect.ShowerAdd(53f, 16.71f, 37.53f, 0, 15, 40, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(20f, 16.71f, 25.53f, 0, -20, 40, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(-5f, 16.71f, 37.53f, 0, -20, 40, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(49f, 15.71f, -20.7f, 0, 90, 50, "quest2_showerLL", 46, 60);//西
            Effect.ShowerAdd(72f, 5.71f, 53.53f, 0, 30, 7, "quest2_showerLLL", 23, 30);//南
            Effect.ShowerAdd(-30f, 1.71f, -20.7f, 0, 0, -20, "quest2_showerLLL", 23, 30);//北西
            Effect.ShowerAdd(-60f, 2.71f, -30.53f, 0, -30, -30, "quest2_showerLLL", 23, 30);//北東
                                                                                           //Effect.ShowerAdd(-35, 28, -70, 0, 25, -20, "quest2_showerL", 105, 105);//北西
            Effect.ShowerAdd(39f, 3.71f, 63.53f, 0, -30, -10, "quest2_showerLLL", 23, 30);//西
            Effect.ShowerAdd(-40.5f, 3.91f, -10.7f, 0, 0, 30, "quest2_showerLLL", 23, 30);//北西
            Effect.ShowerAdd(-4f, 7.71f, 20.53f, 0, -30, -30, "quest2_showerLLL", 23, 30);//北東
            Effect.ShowerAdd(30f, 20.71f, -35.7f, 0, -40, 40, "quest2_showerLL", 46, 60);//西 
            Effect.ShowerAdd(-75f, 11.71f, 07.53f, 0, -30, -13, "quest2_showerLL", 46, 60);//北東
            Effect.ShowerAdd(30f, 20.71f, -35.7f, 0, -40, 40, "quest2_showerLL", 46, 60);//西 
            Effect.ShowerAdd(72f, 5.71f, 47.7f, 0, 40, 10, "quest2_showerLL", 46, 60);//西 
                                                                                      //Effect.ShowerAdd(55.33f, 33.28f, 16.2f, 0, 70, -19, "quest2_showerL", 137, 137);//南（5kmの基準）
            Effect.ShowerAdd(39f, 3.71f, -33.53f, 0, -30, 10, "quest2_showerLLL", 23, 30);//西
            Effect.ShowerAdd(-40.5f, 3.91f, -30.7f, 0, 0, -10, "quest2_showerLLL", 23, 30);//北西
            Effect.ShowerAdd(-4f, 7.71f, 40.53f, 0, -30, 25, "quest2_showerLLL", 23, 30);//北東
            Effect.ShowerAdd(79f, 5.91f, 43.53f, 0, 30, 30, "quest2_showerLLL", 23, 30);//南
            Effect.ShowerAdd(37.5f, 4.91f, -39.7f, 0, 0, 0, "quest2_showerLLL", 23, 30);//西
            Effect.ShowerAdd(-9f, 5.71f, 30.53f, 0, -30, 0, "quest2_showerLLL", 23, 30);//東
            Effect.ShowerAdd(-45f, 18.41f, 37.53f, 0, -160, -25, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(45f, 10.71f, -36.7f, 0, -40, -17, "quest2_showerLL", 46, 60);//西


            Effect.ShowerAdd(23f, 16.71f, 57.53f, 0, 15, 40, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(-20f, 16.71f, 65.53f, 0, -20, 40, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(-35f, 16.71f, 77.53f, 0, -20, 40, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(29f, 15.71f, -70.7f, 0, 90, 50, "quest2_showerLL", 46, 60);//西
            Effect.ShowerAdd(-72f, 5.71f, 33.53f, 0, 30, 7, "quest2_showerLLL", 23, 30);//南
            Effect.ShowerAdd(30f, 1.71f, -60.7f, 0, 0, -20, "quest2_showerLLL", 23, 30);//北西
            Effect.ShowerAdd(-10f, 2.71f, 30.53f, 0, -30, -30, "quest2_showerLLL", 23, 30);//北東
                                                                                           //Effect.ShowerAdd(-35, 28, -70, 0, 25, -20, "quest2_showerL", 105, 105);//北西
            Effect.ShowerAdd(-39f, 3.71f, -63.53f, 0, -30, -10, "quest2_showerLLL", 23, 30);//西
            Effect.ShowerAdd(-10.5f, 3.91f, -50.7f, 0, 0, 30, "quest2_showerLLL", 23, 30);//北西
            Effect.ShowerAdd(-40f, 7.71f, 80.53f, 0, -30, -30, "quest2_showerLLL", 23, 30);//北東
            Effect.ShowerAdd(-30f, 20.71f, -75.7f, 0, -40, 40, "quest2_showerLL", 46, 60);//西 
            Effect.ShowerAdd(-55f, 11.71f, 37.53f, 0, -30, -13, "quest2_showerLL", 46, 60);//北東
            Effect.ShowerAdd(60f, 20.71f, -75.7f, 0, -40, 40, "quest2_showerLL", 46, 60);//西 
            Effect.ShowerAdd(22f, 5.71f, 27.7f, 0, 40, 10, "quest2_showerLL", 46, 60);//西 
                                                                                      //Effect.ShowerAdd(55.33f, 33.28f, 16.2f, 0, 70, -19, "quest2_showerL", 137, 137);//南（5kmの基準）
            Effect.ShowerAdd(19f, 3.71f, -63.53f, 0, -30, 10, "quest2_showerLLL", 23, 30);//西
            Effect.ShowerAdd(40.5f, 3.91f, -50.7f, 0, 0, -10, "quest2_showerLLL", 23, 30);//北西
            Effect.ShowerAdd(-40f, 7.71f, 80.53f, 0, -30, 25, "quest2_showerLLL", 23, 30);//北東
            Effect.ShowerAdd(36f, 5.91f, 23.53f, 0, 30, 30, "quest2_showerLLL", 23, 30);//南
            Effect.ShowerAdd(-37.5f, 4.91f, -69.7f, 0, 0, 0, "quest2_showerLLL", 23, 30);//西
            Effect.ShowerAdd(-29f, 5.71f, 80.53f, 0, -30, 0, "quest2_showerLLL", 23, 30);//東
            Effect.ShowerAdd(35f, 18.41f, 67.53f, 0, -160, -25, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(-35f, 10.71f, -66.7f, 0, -40, -17, "quest2_showerLL", 46, 60);//西

            Effect.ShowerAdd(-33f, 16.71f, 37.53f, 0, 15, 40, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(40f, 16.71f, 25.53f, 0, -20, 40, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(-35f, 16.71f, 37.53f, 0, -20, 40, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(-49f, 15.71f, -20.7f, 0, 90, 50, "quest2_showerLL", 46, 60);//西
            Effect.ShowerAdd(-32f, 5.71f, 53.53f, 0, 30, 7, "quest2_showerLLL", 23, 30);//南
            Effect.ShowerAdd(40f, 1.71f, -20.7f, 0, 0, -20, "quest2_showerLLL", 23, 30);//北西
            Effect.ShowerAdd(-20f, 2.71f, -30.53f, 0, -30, -30, "quest2_showerLLL", 23, 30);//北東
                                                                                            //Effect.ShowerAdd(-35, 28, -70, 0, 25, -20, "quest2_showerL", 105, 105);//北西
            Effect.ShowerAdd(-39f, 3.71f, 63.53f, 0, -30, -10, "quest2_showerLLL", 23, 30);//西
            Effect.ShowerAdd(40.5f, 3.91f, -10.7f, 0, 0, 30, "quest2_showerLLL", 23, 30);//北西
            Effect.ShowerAdd(-34f, 7.71f, 20.53f, 0, -30, -30, "quest2_showerLLL", 23, 30);//北東
            Effect.ShowerAdd(60f, 20.71f, -35.7f, 0, -40, 40, "quest2_showerLL", 46, 60);//西 
            Effect.ShowerAdd(75f, 11.71f, 07.53f, 0, -30, -13, "quest2_showerLL", 46, 60);//北東
            Effect.ShowerAdd(-30f, 20.71f, -35.7f, 0, -40, 40, "quest2_showerLL", 46, 60);//西 
            Effect.ShowerAdd(-52f, 5.71f, 47.7f, 0, 40, 10, "quest2_showerLL", 46, 60);//西 
                                                                                      //Effect.ShowerAdd(55.33f, 33.28f, 16.2f, 0, 70, -19, "quest2_showerL", 137, 137);//南（5kmの基準）
            Effect.ShowerAdd(59f, 3.71f, -33.53f, 0, -30, 10, "quest2_showerLLL", 23, 30);//西
            Effect.ShowerAdd(-50.5f, 3.91f, -30.7f, 0, 0, -10, "quest2_showerLLL", 23, 30);//北西
            Effect.ShowerAdd(-40f, 7.71f, 40.53f, 0, -30, 25, "quest2_showerLLL", 23, 30);//北東
            Effect.ShowerAdd(-79f, 5.91f, 43.53f, 0, 30, 30, "quest2_showerLLL", 23, 30);//南
            Effect.ShowerAdd(17.5f, 4.91f, -39.7f, 0, 0, 0, "quest2_showerLLL", 23, 30);//西
            Effect.ShowerAdd(-29f, 5.71f, 30.53f, 0, -30, 0, "quest2_showerLLL", 23, 30);//東
            Effect.ShowerAdd(35f, 18.41f, 37.53f, 0, -160, -25, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(-45f, 10.71f, -36.7f, 0, -40, -17, "quest2_showerLL", 46, 60);//西



            Effect.ShowerAdd(53f, 16.71f, 57.53f, 0, -15, 40, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(20f, 16.71f, 65.53f, 0, -20, 40, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(-5f, 16.71f, 77.53f, 0, -20, 40, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(49f, 15.71f, -70.7f, 0, -90, 50, "quest2_showerLL", 46, 60);//西
            Effect.ShowerAdd(72f, 5.71f, 33.53f, 0, -30, 7, "quest2_showerLLL", 23, 30);//南
            Effect.ShowerAdd(-30f, 1.71f, -60.7f, 0, 0, -20, "quest2_showerLLL", 23, 30);//北西
            Effect.ShowerAdd(-60f, 2.71f, 30.53f, 0, -30, -30, "quest2_showerLLL", 23, 30);//北東
                                                                                           //Effect.ShowerAdd(-35, 28, -70, 0, 25, -20, "quest2_showerL", 105, 105);//北西
            Effect.ShowerAdd(39f, 3.71f, -63.53f, 0, -30, -10, "quest2_showerLLL", 23, 30);//西
            Effect.ShowerAdd(-40.5f, 3.91f, -50.7f, 0, 0, 30, "quest2_showerLLL", 23, 30);//北西
            Effect.ShowerAdd(-4f, 7.71f, 80.53f, 0, -30, -30, "quest2_showerLLL", 23, 30);//北東
            Effect.ShowerAdd(30f, 20.71f, -75.7f, 0, -40, 40, "quest2_showerLL", 46, 60);//西 
            Effect.ShowerAdd(-75f, 11.71f, 37.53f, 0, -30, -13, "quest2_showerLL", 46, 60);//北東
            Effect.ShowerAdd(30f, 20.71f, -75.7f, 0, -40, 40, "quest2_showerLL", 46, 60);//西 
            Effect.ShowerAdd(72f, 5.71f, 27.7f, 0, -40, 10, "quest2_showerLL", 46, 60);//西 
                                                                                      //Effect.ShowerAdd(55.33f, 33.28f, 16.2f, 0, 70, -19, "quest2_showerL", 137, 137);//南（5kmの基準）
            Effect.ShowerAdd(39f, 3.71f, -63.53f, 0, -30, 10, "quest2_showerLLL", 23, 30);//西
            Effect.ShowerAdd(-40.5f, 3.91f, -50.7f, 0, 0, -10, "quest2_showerLLL", 23, 30);//北西
            Effect.ShowerAdd(-4f, 7.71f, 80.53f, 0, -30, 25, "quest2_showerLLL", 23, 30);//北東
            Effect.ShowerAdd(79f, 5.91f, 23.53f, 0, -30, 30, "quest2_showerLLL", 23, 30);//南
            Effect.ShowerAdd(37.5f, 4.91f, -69.7f, 0, 0, 0, "quest2_showerLLL", 23, 30);//西
            Effect.ShowerAdd(-9f, 5.71f, 80.53f, 0, -30, 0, "quest2_showerLLL", 23, 30);//東
            Effect.ShowerAdd(-45f, 18.41f, 67.53f, 0, -160, -25, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(45f, 10.71f, -66.7f, 0, -40, -17, "quest2_showerLL", 46, 60);//西

            Effect.ShowerAdd(53f, 16.71f, 37.53f, 0, -15, 40, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(20f, 16.71f, 25.53f, 0, -20, 40, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(-5f, 16.71f, 37.53f, 0, -20, 40, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(49f, 15.71f, -20.7f, 0, -90, 50, "quest2_showerLL", 46, 60);//西
            Effect.ShowerAdd(72f, 5.71f, 53.53f, 0, -30, 7, "quest2_showerLLL", 23, 30);//南
            Effect.ShowerAdd(-30f, 1.71f, -20.7f, 0, 0, -20, "quest2_showerLLL", 23, 30);//北西
            Effect.ShowerAdd(-60f, 2.71f, -30.53f, 0, -30, -30, "quest2_showerLLL", 23, 30);//北東
                                                                                            //Effect.ShowerAdd(-35, 28, -70, 0, 25, -20, "quest2_showerL", 105, 105);//北西
            Effect.ShowerAdd(39f, 3.71f, 63.53f, 0, -30, -10, "quest2_showerLLL", 23, 30);//西
            Effect.ShowerAdd(-40.5f, 3.91f, -10.7f, 0, 0, 30, "quest2_showerLLL", 23, 30);//北西
            Effect.ShowerAdd(-4f, 7.71f, 20.53f, 0, -30, -30, "quest2_showerLLL", 23, 30);//北東
            Effect.ShowerAdd(30f, 20.71f, -35.7f, 0, -40, 40, "quest2_showerLL", 46, 60);//西 
            Effect.ShowerAdd(-75f, 11.71f, 07.53f, 0, -30, -13, "quest2_showerLL", 46, 60);//北東
            Effect.ShowerAdd(30f, 20.71f, -35.7f, 0, -40, 40, "quest2_showerLL", 46, 60);//西 
            Effect.ShowerAdd(72f, 5.71f, 47.7f, 0, -40, 10, "quest2_showerLL", 46, 60);//西 
                                                                                      //Effect.ShowerAdd(55.33f, 33.28f, 16.2f, 0, 70, -19, "quest2_showerL", 137, 137);//南（5kmの基準）
            Effect.ShowerAdd(39f, 3.71f, -33.53f, 0, -30, 10, "quest2_showerLLL", 23, 30);//西
            Effect.ShowerAdd(-40.5f, 3.91f, -30.7f, 0, 0, -10, "quest2_showerLLL", 23, 30);//北西
            Effect.ShowerAdd(-4f, 7.71f, 40.53f, 0, -30, 25, "quest2_showerLLL", 23, 30);//北東
            Effect.ShowerAdd(79f, 5.91f, 43.53f, 0, -30, 30, "quest2_showerLLL", 23, 30);//南
            Effect.ShowerAdd(37.5f, 4.91f, -39.7f, 0, 0, 0, "quest2_showerLLL", 23, 30);//西
            Effect.ShowerAdd(-9f, 5.71f, 30.53f, 0, -30, 0, "quest2_showerLLL", 23, 30);//東
            Effect.ShowerAdd(-45f, 18.41f, 37.53f, 0, -160, -25, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(45f, 10.71f, -36.7f, 0, -40, -17, "quest2_showerLL", 46, 60);//西

            Effect.ShowerAdd(53f, 16.71f, 10.53f, 0, 60, 0, "quest2_showerLL", 100, 120);//東
            Effect.ShowerAdd(0f, 16.71f, -50.53f, 0, 30, 0, "quest2_showerLL", 100, 120);//東
            Effect.ShowerAdd(0f, 16.71f, -50.53f, 0, 30, 20, "quest2_showerLL", 100, 120);//東
            Effect.ShowerAdd(0f, 16.71f, -50.53f, 0, 30, -20, "quest2_showerLL", 100, 120);//東
            Effect.ShowerAdd(-60f, 16.71f, 20f, 0, 70, 0, "quest2_showerLL", 100, 120);//東

            Effect.ShowerAdd(23f, 16.71f, 57.53f, 0, -15, 40, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(-20f, 16.71f, 65.53f, 0, -20, 40, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(-35f, 16.71f, 77.53f, 0, -20, 40, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(29f, 15.71f, -70.7f, 0, -90, 50, "quest2_showerLL", 46, 60);//西
            Effect.ShowerAdd(-72f, 5.71f, 33.53f, 0, -30, 7, "quest2_showerLLL", 23, 30);//南
            Effect.ShowerAdd(30f, 1.71f, -60.7f, 0, 0, -20, "quest2_showerLLL", 23, 30);//北西
            Effect.ShowerAdd(-10f, 2.71f, 30.53f, 0, -30, -30, "quest2_showerLLL", 23, 30);//北東
                                                                                           //Effect.ShowerAdd(-35, 28, -70, 0, 25, -20, "quest2_showerL", 105, 105);//北西
            Effect.ShowerAdd(-39f, 3.71f, -63.53f, 0, -30, -10, "quest2_showerLLL", 23, 30);//西
            Effect.ShowerAdd(-10.5f, 3.91f, -50.7f, 0, 0, 30, "quest2_showerLLL", 23, 30);//北西
            Effect.ShowerAdd(-40f, 7.71f, 80.53f, 0, -30, -30, "quest2_showerLLL", 23, 30);//北東
            Effect.ShowerAdd(-30f, 20.71f, -75.7f, 0, -40, 40, "quest2_showerLL", 46, 60);//西 
            Effect.ShowerAdd(-55f, 11.71f, 37.53f, 0, -30, -13, "quest2_showerLL", 46, 60);//北東
            Effect.ShowerAdd(60f, 20.71f, -75.7f, 0, -40, 40, "quest2_showerLL", 46, 60);//西 
            Effect.ShowerAdd(22f, 5.71f, 27.7f, 0, -40, 10, "quest2_showerLL", 46, 60);//西 
                                                                                      //Effect.ShowerAdd(55.33f, 33.28f, 16.2f, 0, 70, -19, "quest2_showerL", 137, 137);//南（5kmの基準）
            Effect.ShowerAdd(19f, 3.71f, -63.53f, 0, -30, 10, "quest2_showerLLL", 23, 30);//西
            Effect.ShowerAdd(40.5f, 3.91f, -50.7f, 0, 0, -10, "quest2_showerLLL", 23, 30);//北西
            Effect.ShowerAdd(-40f, 7.71f, 80.53f, 0, -30, 25, "quest2_showerLLL", 23, 30);//北東
            Effect.ShowerAdd(36f, 5.91f, 23.53f, 0, -30, 30, "quest2_showerLLL", 23, 30);//南
            Effect.ShowerAdd(-37.5f, 4.91f, -69.7f, 0, 0, 0, "quest2_showerLLL", 23, 30);//西
            Effect.ShowerAdd(-29f, 5.71f, 80.53f, 0, -30, 0, "quest2_showerLLL", 23, 30);//東
            Effect.ShowerAdd(35f, 18.41f, 67.53f, 0, -160, -25, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(-35f, 10.71f, -66.7f, 0, -40, -17, "quest2_showerLL", 46, 60);//西

            Effect.ShowerAdd(-33f, 16.71f, 37.53f, 0, -15, 40, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(40f, 16.71f, 25.53f, 0, -20, 40, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(-35f, 16.71f, 37.53f, 0, -20, 40, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(-49f, 15.71f, -20.7f, 0, -90, 50, "quest2_showerLL", 46, 60);//西
            Effect.ShowerAdd(-32f, 5.71f, 53.53f, 0, -30, 7, "quest2_showerLLL", 23, 30);//南
            Effect.ShowerAdd(40f, 1.71f, -20.7f, 0, 0, -20, "quest2_showerLLL", 23, 30);//北西
            Effect.ShowerAdd(-20f, 2.71f, -30.53f, 0, -30, -30, "quest2_showerLLL", 23, 30);//北東
                                                                                            //Effect.ShowerAdd(-35, 28, -70, 0, 25, -20, "quest2_showerL", 105, 105);//北西
            Effect.ShowerAdd(-39f, 3.71f, 63.53f, 0, -30, -10, "quest2_showerLLL", 23, 30);//西
            Effect.ShowerAdd(40.5f, 3.91f, -10.7f, 0, 0, 30, "quest2_showerLLL", 23, 30);//北西
            Effect.ShowerAdd(-34f, 7.71f, 20.53f, 0, -30, -30, "quest2_showerLLL", 23, 30);//北東
            Effect.ShowerAdd(60f, 20.71f, -35.7f, 0, -40, 40, "quest2_showerLL", 46, 60);//西 
            Effect.ShowerAdd(75f, 11.71f, 07.53f, 0, -30, -13, "quest2_showerLL", 46, 60);//北東
            Effect.ShowerAdd(-30f, 20.71f, -35.7f, 0, -40, 40, "quest2_showerLL", 46, 60);//西 
            Effect.ShowerAdd(-52f, 5.71f, 47.7f, 0, -40, 10, "quest2_showerLL", 46, 60);//西 
                                                                                       //Effect.ShowerAdd(55.33f, 33.28f, 16.2f, 0, 70, -19, "quest2_showerL", 137, 137);//南（5kmの基準）
            Effect.ShowerAdd(59f, 3.71f, -33.53f, 0, -30, 10, "quest2_showerLLL", 23, 30);//西
            Effect.ShowerAdd(-50.5f, 3.91f, -30.7f, 0, 0, -10, "quest2_showerLLL", 23, 30);//北西
            Effect.ShowerAdd(-40f, 7.71f, 40.53f, 0, -30, 25, "quest2_showerLLL", 23, 30);//北東
            Effect.ShowerAdd(-79f, 5.91f, 43.53f, 0, -30, 30, "quest2_showerLLL", 23, 30);//南
            Effect.ShowerAdd(17.5f, 4.91f, -39.7f, 0, 0, 0, "quest2_showerLLL", 23, 30);//西
            Effect.ShowerAdd(-29f, 5.71f, 30.53f, 0, -30, 0, "quest2_showerLLL", 23, 30);//東
            Effect.ShowerAdd(35f, 18.41f, 37.53f, 0, -160, -25, "quest2_showerLL", 46, 60);//東
            Effect.ShowerAdd(-45f, 10.71f, -36.7f, 0, -40, -17, "quest2_showerLL", 46, 60);//西
                                                                                           //Effect.ShowerAdd(-6.2f, 32.28f, 45.33f, 0, 0, -14, "quest2_showerL", 100, 100);//東
            yield return new WaitForSeconds(6f);
        }
        //Effect.ShowerAdd(-2f, 16.71f, 83.53f, 0, -20, 40, "quest2_showerLL", 46, 60);//東

        Effect.ShowerAdd(20f, 16.71f, 65.53f, 0, -20, 40, "quest2_showerLL", 46, 60);//東
        Effect.ShowerAdd(-5f, 16.71f, 77.53f, 0, -20, 40, "quest2_showerLL", 46, 60);//東
        Effect.ShowerAdd(49f, 15.71f, -70.7f, 0, 90, 50, "quest2_showerLL", 46, 60);//西
        Effect.ShowerAdd(72f, 5.71f, 33.53f, 0, 30, 7, "quest2_showerLLL", 23, 30);//南
        Effect.ShowerAdd(-30f, 1.71f, -60.7f, 0, 0, -20, "quest2_showerLLL", 23, 30);//北西
        Effect.ShowerAdd(-60f, 2.71f, 30.53f, 0, -30, -30, "quest2_showerLLL", 23, 30);//北東
        //Effect.ShowerAdd(-35, 28, -70, 0, 25, -20, "quest2_showerL", 105, 105);//北西
        Effect.ShowerAdd(39f, 3.71f, -63.53f, 0, -30, -10, "quest2_showerLLL", 23, 30);//西
        Effect.ShowerAdd(-40.5f, 3.91f, -50.7f, 0, 0, 30, "quest2_showerLLL", 23, 30);//北西
        Effect.ShowerAdd(-4f, 7.71f, 80.53f, 0, -30, -30, "quest2_showerLLL", 23, 30);//北東
        Effect.ShowerAdd(30f, 20.71f, -75.7f, 0, -40, 40, "quest2_showerLL", 46, 60);//西 
        Effect.ShowerAdd(-75f, 11.71f, 37.53f, 0, -30, -13, "quest2_showerLL", 46, 60);//北東
        Effect.ShowerAdd(30f, 20.71f, -75.7f, 0, -40, 40, "quest2_showerLL", 46, 60);//西 
        Effect.ShowerAdd(72f, 5.71f, 27.7f, 0, 40, 10, "quest2_showerLL", 46, 60);//西 
        //Effect.ShowerAdd(55.33f, 33.28f, 16.2f, 0, 70, -19, "quest2_showerL", 137, 137);//南（5kmの基準）
        Effect.ShowerAdd(39f, 3.71f, -63.53f, 0, -30, 10, "quest2_showerLLL", 23, 30);//西
        Effect.ShowerAdd(-40.5f, 3.91f, -50.7f, 0, 0, -10, "quest2_showerLLL", 23, 30);//北西
        Effect.ShowerAdd(-4f, 7.71f, 80.53f, 0, -30, 25, "quest2_showerLLL", 23, 30);//北東
        Effect.ShowerAdd(79f, 5.91f, 23.53f, 0, 30, 30, "quest2_showerLLL", 23, 30);//南
        Effect.ShowerAdd(37.5f, 4.91f, -69.7f, 0, 0, 0, "quest2_showerLLL", 23, 30);//西
        Effect.ShowerAdd(-9f, 5.71f, 80.53f, 0, -30, 0, "quest2_showerLLL", 23, 30);//東
        Effect.ShowerAdd(-45f, 18.41f, 67.53f, 0, -160, -25, "quest2_showerLL", 46, 60);//東
        Effect.ShowerAdd(45f, 10.71f, -66.7f, 0, -40, -17, "quest2_showerLL", 46, 60);//西
        //Effect.ShowerAdd(-6.2f, 32.28f, 45.33f, 0, 0, -14, "quest2_showerL", 100, 100);//東


        int temp = 0;
        int new_x = 1;

        //yield return new WaitForSeconds(14.0f);//小学生用ナレーションのシャワーのイントロダクションまで待つ(小学生用ナレーション）
        yield return new WaitForSeconds(13.0f);//小学生用ナレーションのシャワーのイントロダクションまで待つ(小学生用ナレーション改）
        //7回目 5km先×1
        Effect2.ShowerAdd(55.33f, 33.28f, 16.2f, 0, 70, -19, "quest2_showerL_introduction", 137, 137);//南（5kmの基準）
        yield return new WaitForSeconds(48.0f);//小学生用ナレーションが終わるまで待つ

        //小学生ナレーション用
        //10km先
        Effect.ShowerAdd(73.27f, 32.28f, 32.46f, 0, 90, 14, "quest2_showerL", 100, 100);//南東
        yield return new WaitForSeconds(6f);//5s待機

        //20km先
        Effect.ShowerAdd(79f, 12.91f, 40.53f, 0, 30, 40, "quest2_showerLL", 46, 60);//南
        yield return new WaitForSeconds(5.8f);//5s待機

        //40km先
        Effect.ShowerAdd(64.08f, 5.71f, 46.93f, 0, 30, 7, "quest2_showerLLL_40kmaudio", 23, 30);//南
        yield return new WaitForSeconds(5f);//5s待機

        //80km先
        Effect.ShowerAdd(78.96f, 0.71f, 8.6f, 0, 30, -7, "quest2_showerLLL_80kmaudio", 11, 15);//南
        yield return new WaitForSeconds(29f);//5s待機

        while (true)
        {

            UnityEngine.Random.InitState(System.DateTime.Now.Millisecond);//シード値を現在時刻に
            new_x = UnityEngine.Random.Range(0, 23);

            if (new_x == temp)
            {
                new_x++;
                if (new_x == 23)
                {
                    new_x = 2;
                }
            }

            temp = new_x;
            Debug.Log("乱数生成成功");
            Debug.Log(new_x);



            switch (new_x)
            {
                case 0:
                    //1回目 20km先×2
                    Effect.ShowerAdd(-5f, 16.71f, 77.53f, 0, -20, 40, "quest2_showerLL", 46, 60);//東
                    Effect.ShowerAdd(49f, 15.71f, -70.7f, 0, 90, 50, "quest2_showerLL", 46, 60);//西
                    yield return new WaitForSeconds(7.0f);//7s待機
                    break;

                case 1:
                    //2回目 40km先×3
                    Effect.ShowerAdd(72f, 5.71f, 33.53f, 0, 30, 7, "quest2_showerLLL", 23, 30);//南
                    Effect.ShowerAdd(-30f, 1.71f, -60.7f, 0, 0, -20, "quest2_showerLLL", 23, 30);//北西
                    Effect.ShowerAdd(-60f, 2.71f, 30.53f, 0, -30, -30, "quest2_showerLLL", 23, 30);//北東
                    yield return new WaitForSeconds(7.0f);//7s待機
                    break;

                case 2:
                    //3回目 10km先×1
                    Effect.ShowerAdd(-35, 28, -70, 0, 25, -20, "quest2_showerL", 105, 105);//北西
                    yield return new WaitForSeconds(7.0f);//7s待機

                    break;

                case 3:

                    //4回目 40km先×3
                    Effect.ShowerAdd(39f, 3.71f, -63.53f, 0, -30, -10, "quest2_showerLLL", 23, 30);//西
                    Effect.ShowerAdd(-40.5f, 3.91f, -50.7f, 0, 0, 30, "quest2_showerLLL", 23, 30);//北西
                    Effect.ShowerAdd(-4f, 7.71f, 80.53f, 0, -30, -30, "quest2_showerLLL", 23, 30);//北東
                    yield return new WaitForSeconds(7.0f);//7s待機
                    break;

                case 4:
                    //5回目 20km先×2
                    //Effect.ShowerAdd(-5f, 8.71f, 77.53f, 0, 20, -25, "quest2_showerLL", 46, 60);//東
                    Effect.ShowerAdd(30f, 20.71f, -75.7f, 0, -40, 40, "quest2_showerLL", 46, 60);//西 
                    yield return new WaitForSeconds(7.0f);//7s待機
                    break;

                case 5:

                    //6回目 20km先×3
                    Effect.ShowerAdd(-75f, 11.71f, 37.53f, 0, -30, -13, "quest2_showerLL", 46, 60);//北東
                    Effect.ShowerAdd(30f, 20.71f, -75.7f, 0, -40, 40, "quest2_showerLL", 46, 60);//西 
                    Effect.ShowerAdd(72f, 5.71f, 27.7f, 0, 40, 10, "quest2_showerLL", 46, 60);//西 
                    yield return new WaitForSeconds(7.0f);//7s待機
                    break;

                case 6:

                    //7回目 5km先×1
                    Effect.ShowerAdd(55.33f, 33.28f, 16.2f, 0, 70, -19, "quest2_showerL", 137, 137);//南（5kmの基準）
                    yield return new WaitForSeconds(7.0f);//7s待機
                    break;

                case 7:

                    //8回目 40km先×3
                    Effect.ShowerAdd(39f, 3.71f, -63.53f, 0, -30, 10, "quest2_showerLLL", 23, 30);//西
                    Effect.ShowerAdd(-40.5f, 3.91f, -50.7f, 0, 0, -10, "quest2_showerLLL", 23, 30);//北西
                    Effect.ShowerAdd(-4f, 7.71f, 80.53f, 0, -30, 25, "quest2_showerLLL", 23, 30);//北東
                    yield return new WaitForSeconds(7.0f);//7s待機
                    break;

                case 8:
                    //9回目 40km先×3
                    Effect.ShowerAdd(79f, 5.91f, 23.53f, 0, 30, 30, "quest2_showerLLL", 23, 30);//南
                    Effect.ShowerAdd(37.5f, 4.91f, -69.7f, 0, 0, 0, "quest2_showerLLL", 23, 30);//西
                    Effect.ShowerAdd(-9f, 5.71f, 80.53f, 0, -30, 0, "quest2_showerLLL", 23, 30);//東
                    yield return new WaitForSeconds(7.0f);//7s待機

                    break;

                case 9:
                    //10回目 20km先×2
                    Effect.ShowerAdd(-45f, 18.41f, 67.53f, 0, -160, -25, "quest2_showerLL", 46, 60);//東
                    Effect.ShowerAdd(45f, 10.71f, -66.7f, 0, -40, -17, "quest2_showerLL", 46, 60);//西 
                    yield return new WaitForSeconds(7.0f);//7s待機

                    break;

                case 10:

                    //11回目 10km先×1
                    Effect.ShowerAdd(-6.2f, 32.28f, 45.33f, 0, 0, -14, "quest2_showerL", 100, 100);//東
                    yield return new WaitForSeconds(7.0f);//7s待機
                    break;

                case 11:
                    //12回目 40km先×3
                    Effect.ShowerAdd(83, 9.01f, -9f, 0, -30, -24, "quest2_showerLLL", 23, 30);//南
                    Effect.ShowerAdd(-20.5f, 4.91f, -70.7f, 0, 0, -30, "quest2_showerLLL", 23, 30);//北西
                    Effect.ShowerAdd(10f, 7.71f, 80.53f, 0, -30, -30, "quest2_showerLLL", 23, 30);//東
                    yield return new WaitForSeconds(7.0f);//7s待機

                    break;

                case 12:
                    //13回目 40km先×2
                    Effect.ShowerAdd(79f, 5.91f, 18.53f, 0, 30, -40, "quest2_showerLLL", 23, 30);//南
                    Effect.ShowerAdd(15f, 6.71f, 75.53f, 0, -10, 30, "quest2_showerLLL", 23, 30);//南東

                    yield return new WaitForSeconds(7.0f);//7s待機

                    break;

                case 13:
                    //14回目 40km先×2
                    Effect.ShowerAdd(79f, 6.91f, 40.53f, 0, 30, 40, "quest2_showerLLL", 23, 30);//南
                    Effect.ShowerAdd(15f, 6.71f, 75.53f, 0, -10, -20, "quest2_showerLLL", 23, 30);//南東
                    yield return new WaitForSeconds(7.0f);//7s待機

                    break;

                case 14:
                    //15回目 20km先×2
                    Effect.ShowerAdd(79f, 12.91f, 40.53f, 0, 30, 40, "quest2_showerLL", 46, 60);//南
                    Effect.ShowerAdd(-30f, 1.71f, -60.7f, 0, 0, -30, "quest2_showerLL", 46, 60);//北西
                    yield return new WaitForSeconds(7.0f);//7s待機

                    break;

                case 15:
                    //16回目 20km先×2
                    Effect.ShowerAdd(49f, 12.91f, 70.53f, 0, 30, 40, "quest2_showerLL", 46, 60);//南
                    Effect.ShowerAdd(-44f, 10.71f, -60.7f, 0, 0, -42, "quest2_showerLL", 46, 60);//北西
                    yield return new WaitForSeconds(7.0f);//7s待機

                    break;
                case 16:
                    //16回目 10km先×1
                    Effect.ShowerAdd(40.2f, 32.28f, 69.33f, 0, 0, -14, "quest2_showerL", 100, 100);//南東
                    yield return new WaitForSeconds(7.0f);//7s待機

                    break;

                case 17:
                    //16回目 40km先×2
                    Effect.ShowerAdd(79f, 6.91f, 40.53f, 0, 30, -40, "quest2_showerLLL", 23, 30);//南
                    Effect.ShowerAdd(-60f, 2.71f, 32.53f, 0, -30, -15, "quest2_showerLLL", 23, 30);//北東
                    yield return new WaitForSeconds(7.0f);//7s待機

                    break;

                case 18:
                    //16回目 40km先×2
                    Effect.ShowerAdd(79f, 6.91f, 20.53f, 0, 30, -45, "quest2_showerLLL", 23, 30);//南
                    Effect.ShowerAdd(37.5f, 4.91f, -69.7f, 0, 0, -30, "quest2_showerLLL", 23, 30);//西
                    Effect.ShowerAdd(-9f, 5.71f, 80.53f, 0, -30, 0, "quest2_showerLLL", 23, 30);//東
                    yield return new WaitForSeconds(7.0f);//7s待機

                    break;
                case 19:
                    //16回目 20km先×2
                    Effect.ShowerAdd(84f, 12.91f, 24.53f, 0, 30, -39, "quest2_showerLL", 46, 60);//南
                    Effect.ShowerAdd(-30f, 1.71f, -60.7f, 0, 0, 20, "quest2_showerLL", 46, 60);//北西
                    yield return new WaitForSeconds(7.0f);//7s待機

                    break;
                case 20:
                    //16回目 20km先×2
                    Effect.ShowerAdd(86f, 12.91f, 48.53f, 0, 30, 39, "quest2_showerLL", 46, 60);//南
                    Effect.ShowerAdd(-40f, 1.71f, -64.7f, 0, 0, -50, "quest2_showerLL", 46, 60);//北西
                    yield return new WaitForSeconds(7.0f);//7s待機

                    break;
                case 21:
                    //16回目 10km先×1
                    Effect.ShowerAdd(86.2f, 32.28f, 36.33f, 0, 40, 17, "quest2_showerL", 96, 96);//南東
                    yield return new WaitForSeconds(7.0f);//7s待機

                    break;
                case 22:
                    //16回目 10km先×1
                    Effect.ShowerAdd(79f, 12.91f, 25.53f, 0, 30, 44, "quest2_showerLL", 46, 60);//南
                    Effect.ShowerAdd(-30f, 1.71f, -60.7f, 0, 0, 30, "quest2_showerLL", 46, 60);//北西
                    yield return new WaitForSeconds(7.0f);//7s待機
                    break;

                default:
                    Debug.Log("failed");
                    break;
            }

        }

    }

}
