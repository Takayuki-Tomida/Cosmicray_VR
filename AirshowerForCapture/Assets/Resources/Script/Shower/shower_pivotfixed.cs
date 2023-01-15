using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class shower_pivotfixed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()

    {
        StartCoroutine("coroutineR");
    }

    // Update is called once per frame
    private IEnumerator coroutineR()
    {
        int temp = -10;
        int new_x = 10;
        while (true)
        {
            UnityEngine.Random.InitState(System.DateTime.Now.Millisecond);//シード値を現在時刻に
            new_x = UnityEngine.Random.Range(0, 9);

            if (new_x == temp)
            {
                new_x++;
                if (new_x == 9)
                {
                    new_x = 0;
                }
            }

            temp = new_x;
            Debug.Log("乱数生成成功");
            Debug.Log(new_x);

            //このシャワーをy軸周りに回転させる-----------------
            //Effect80km.ShowerAdd(119f, 14.8f, 0f, 0, 0, -37, "80kmshower", 11, 15);//南南西
            //Effect40km.ShowerAdd(116f, 29.1f, 0f, 0, 0, -17, "40kmshower", 23, 30);//南南西
            //Effect20km.ShowerAdd(107f, 53.67f, 0f, 0, 0, -19, "20kmshower", 46, 60);//南南西
            //Effect10km.ShowerAdd(84.85f, 84.85f, 0f, 0, 0, -37, "10kmshower", 96, 96);//南南東
            //Effect5km.ShowerAdd(60f, 103.92f, 0f, 0, 0, -17, "5kmshower", 137, 137);//南南西
            //このシャワーをy軸周りに回転させる-----------------

            //test here---------------------------------------------------
            for (int i = 0; i < 900; i++)
            {
                //Effect10km.ShowerAdd(-13.27f, 84.85f, -83.8f, 0, 0, 4, "10kmshower", 96, 115.2f);//西
                Effect10km.ShowerAdd(7.17f, 84.85f, -84.54f, 0, 0, 20, "10kmshower", 96, 115.2f);//西
                yield return new WaitForSeconds(12.1f);//8s待機
            }
            //test here---------------------------------------------------

            //put 5km shower here-----------------------------------------
            //Effect5km.ShowerAdd(56.75f, 103.92f, 19.49f, 0, 0, -17, "5kmshower", 120, 140);//南西
            //Effect5km.ShowerAdd(57.367f, 103.92f, -17.59f, 0, 0, 14, "5kmshower", 120, 140);//南西
            //Effect5km.ShowerAdd(53.62f, 103.92f, 26.93f, 0, 0, 10, "5kmshower", 120, 140);//南
            //Effect5km.ShowerAdd(32.97f, 103.92f, 50.132f, 0, 0, -17, "5kmshower", 120, 140);//南
            //Effect5km.ShowerAdd(32.97f, 103.92f, 50.13f, 0, 0, 20, "5kmshower", 120, 140);//南東
            //Effect5km.ShowerAdd(32.97f, 103.92f, 50.13f, 0, 0, 6, "5kmshower", 120, 140);//南東
            //Effect5km.ShowerAdd(-12.13f, 103.92f, 58.76f, 0, 0, 8, "5kmshower", 120, 140);//東
            //Effect5km.ShowerAdd(-39.88f, 103.92f, 44.82f, 0, 0, -18, "5kmshower", 120, 140);//東
            //Effect5km.ShowerAdd(-44.35f, 103.92f, 40.4f, 0, 0, 8, "5kmshower", 120, 140);//北東
            //Effect5km.ShowerAdd(-58.61f, 103.92f, 12.81f, 0, 0, -18, "5kmshower", 120, 140);//北東
            //Effect5km.ShowerAdd(-20.35f, 103.92f, -56.43f, 0, 0, -18, "5kmshower", 120, 140);//北西
            //Effect5km.ShowerAdd(-20.35f, 103.92f, -56.43f, 0, 0, 0, "5kmshower", 120, 140);//北西
            //Effect5km.ShowerAdd(44.35f, 103.92f, -40.4f, 0, 0, -13, "5kmshower", 120, 140);//西
            //Effect5km.ShowerAdd(-12.81f, 103.92f, -58.608f, 0, 0, 13, "5kmshower", 120, 140);//西
            //put 5km shower here-----------------------------------------

            //put 10km shower here----------------------------------------
            //Effect10km.ShowerAdd(84.85f, 84.85f, 0f, 0, 0, -7, "10kmshower", 96, 115.2f);//南西
            //Effect10km.ShowerAdd(83.219f, 84.85f, 16.55f, 0, 0, -16, "10kmshower", 96, 115.2f);//南西
            //Effect10km.ShowerAdd(68.64f, 84.85f, 49.87f, 0, 0, -17, "10kmshower", 96, 115.2f);//南
            //Effect10km.ShowerAdd(80.69f, 84.85f, 26.218f, 0, 0, 22, "10kmshower", 96, 115.2f);//南
            //Effect10km.ShowerAdd(34.51f, 84.85f, 77.51f, 0, 0, 7, "10kmshower", 96, 115.2f);//南東
            //Effect10km.ShowerAdd(34.51f, 84.85f, 77.51f, 0, 0, -17, "10kmshower", 96, 115.2f);//南東
            //Effect10km.ShowerAdd(-8.87f, 84.85f, 84.38f, 0, 0, 20, "10kmshower", 96, 115.2f);//東
            //Effect10km.ShowerAdd(-8.87f, 84.85f, 84.38f, 0, 0, -4, "10kmshower", 96, 115.2f);//東
            //Effect10km.ShowerAdd(-66.75f, 84.85f, 52.37f, 0, 0, 14, "10kmshower", 96, 115.2f);//北東
            //Effect10km.ShowerAdd(-80.636f, 84.85f, 26.38f, 0, 0, -18, "10kmshower", 96, 115.2f);//北東
            //Effect10km.ShowerAdd(-68.64f, 84.85f, -49.87f, 0, 0, 24, "10kmshower", 96, 115.2f);//北西
            //Effect10km.ShowerAdd(-54.71f, 84.85f, -64.847f, 0, 0, 0, "10kmshower", 96, 115.2f);//北西
            //Effect10km.ShowerAdd(-13.27f, 84.85f, -83.8f, 0, 0, 4, "10kmshower", 96, 115.2f);//西
            //Effect10km.ShowerAdd(7.17f, 84.85f, -84.54f, 0, 0, 20, "10kmshower", 96, 115.2f);//西
            //put 10km shower here----------------------------------------

            //put 20km shower here----------------------------------------
            //Effect20km.ShowerAdd(107f, 53.67f, 0f, 0, 0, 3, "20kmshower", 60, 72);//南西
            //Effect20km.ShowerAdd(103.354f, 53.67f, -27.693f, 0, 0, 23, "20kmshower", 60, 72);//南西
            //Effect20km.ShowerAdd(86.56f, 53.67f, 62.89f, 0, 0, -20, "20kmshower", 60, 72);//南
            //Effect20km.ShowerAdd(96.64f, 53.67f, 45.91f, 0, 0, 0, "20kmshower", 60, 72);//南
            //Effect20km.ShowerAdd(33.06f, 53.67f, 101.75f, 0, 0, 0, "20kmshower", 60, 72);//南東
            //Effect20km.ShowerAdd(62.88f, 53.67f, 86.55f, 0, 0, 20, "20kmshower", 60, 72);//南東
            //Effect20km.ShowerAdd(-33.06f, 53.67f, 101.75f, 0, 0, 9, "20kmshower", 60, 72);//東
            //Effect20km.ShowerAdd(-33.06f, 53.67f, 101.75f, 0, 0, -19, "20kmshower", 60, 72);//東
            //Effect20km.ShowerAdd(-86.56f, 53.67f, 62.89f, 0, 0, 29, "20kmshower", 60, 72);//北東
            //Effect20km.ShowerAdd(-100.77f, 53.67f, 35.955f, 0, 0, -29, "20kmshower", 60, 72);//北東
            //Effect20km.ShowerAdd(-75.65f, 53.67f, -75.65f, 0, 0, 29, "20kmshower", 60, 72);//北西
            //Effect20km.ShowerAdd(-51.27f, 53.67f, -93.898f, 0, 0, -3, "20kmshower", 60, 72);//北西
            //Effect20km.ShowerAdd(3.87f, 53.67f, -107f, 0, 0, -9, "20kmshower", 60, 72);//西
            //Effect20km.ShowerAdd(3.87f, 53.67f, -107f, 0, 0, 23, "20kmshower", 60, 72);//西
            //put 20km shower here----------------------------------------

            //put 40km shower here----------------------------------------
            //Effect40km.ShowerAdd(116f, 29.1f, 0f, 0, 0, -10, "40kmshower", 30, 40);//南西
            //Effect40km.ShowerAdd(116f, 29.1f, 0f, 0, 0, 18, "40kmshower", 30, 40);//南西
            //Effect40km.ShowerAdd(105.7f, 29.1f, 47.78f, 0, 0, 20, "40kmshower", 30, 40);//南
            //Effect40km.ShowerAdd(105.7f, 29.1f, 47.78f, 0, 0, -20, "40kmshower", 30, 40);//南
            //Effect40km.ShowerAdd(57.43f, 29.1f, 100.78f, 0, 0, -20, "40kmshower", 30, 40);//南東
            //Effect40km.ShowerAdd(78.415f, 29.1f, 85.473f, 0, 0, 13, "40kmshower", 30, 40);//南東
            //Effect40km.ShowerAdd(-30.65f, 29.1f, 111.87f, 0, 0, 4, "40kmshower", 30, 40);//東
            //Effect40km.ShowerAdd(-8.236f, 29.1f, 115.699f, 0, 0, -17, "40kmshower", 30, 40);//東
            //Effect40km.ShowerAdd(-100.78f, 29.1f, 57.42f, 0, 0, 14, "40kmshower", 30, 40);//北東
            //Effect40km.ShowerAdd(-104.463f, 29.1f, 50.408f, 0, 0, -12, "40kmshower", 30, 40);//北東
            //Effect40km.ShowerAdd(-57.43f, 29.1f, -100.78f, 0, 0, -24, "40kmshower", 30, 40);//北西
            //Effect40km.ShowerAdd(-57.43f, 29.1f, -100.78f, 0, 0, 24, "40kmshower", 30, 40);//北西
            //Effect40km.ShowerAdd(30.656f, 29.1f, -111.87f, 0, 0, 24, "40kmshower", 30, 40);//西
            //Effect40km.ShowerAdd(60.931f, 29.1f, -98.70f, 0, 0, -14, "40kmshower", 30, 40);//西
            //put 40km shower here----------------------------------------

            //put 80km shower here----------------------------------------
            //80km先は3方向以外だとほとんどシャワーが見えない
            //Effect80km.ShowerAdd(119f, 14.8f, 0f, 0, 0, 30, "80kmshower", 12, 20.8f);//南西
            //Effect80km.ShowerAdd(119f, 14.8f, 0f, 0, 0, -20, "80kmshower", 12, 20.8f);//南西
            //Effect80km.ShowerAdd(47.13f, 14.8f, -109.26f, 0, 0, -10, "80kmshower", 12, 20.8f);//西
            //Effect80km.ShowerAdd(47.13f, 14.8f, -109.26f, 0, 0, 20, "80kmshower", 12, 20.8f);//西
            //Effect80km.ShowerAdd(-81.66f, 14.8f, -86.557f, 0, 0, 30, "80kmshower", 12, 20.8f);//北西
            //Effect80km.ShowerAdd(-72.484f, 14.8f, -94.374f, 0, 0, -20, "80kmshower", 12, 20.8f);//北西
            //put 80km shower here----------------------------------------

            //put 南西 shower here----------------------------------------
            //Effect5km.ShowerAdd(56.75f, 103.92f, 19.49f, 0, 0, -17, "5kmshower", 120, 140);//南西
            //Effect5km.ShowerAdd(57.367f, 103.92f, -17.59f, 0, 0, 14, "5kmshower", 120, 140);//南西
            //Effect10km.ShowerAdd(84.85f, 84.85f, 0f, 0, 0, -7, "10kmshower", 96, 115.2f);//南西
            //Effect10km.ShowerAdd(83.219f, 84.85f, 16.55f, 0, 0, -16, "10kmshower", 96, 115.2f);//南西
            //Effect20km.ShowerAdd(107f, 53.67f, 0f, 0, 0, 3, "20kmshower", 60, 72);//南西
            //Effect20km.ShowerAdd(103.354f, 53.67f, -27.693f, 0, 0, 23, "20kmshower", 60, 72);//南西
            //Effect40km.ShowerAdd(116f, 29.1f, 0f, 0, 0, -10, "40kmshower", 30, 40);//南西
            //Effect40km.ShowerAdd(116f, 29.1f, 0f, 0, 0, 18, "40kmshower", 30, 40);//南西
            //Effect80km.ShowerAdd(119f, 14.8f, 0f, 0, 0, 30, "80kmshower", 12, 20.8f);//南西
            //Effect80km.ShowerAdd(119f, 14.8f, 0f, 0, 0, -20, "80kmshower", 12, 20.8f);//南西
            //put 南西 shower here----------------------------------------

            //put 南 shower here------------------------------------------
            //Effect5km.ShowerAdd(53.62f, 103.92f, 26.93f, 0, 0, 10, "5kmshower", 120, 140);//南
            //Effect5km.ShowerAdd(32.97f, 103.92f, 50.132f, 0, 0, -17, "5kmshower", 120, 140);//南
            //Effect10km.ShowerAdd(68.64f, 84.85f, 49.87f, 0, 0, -17, "10kmshower", 96, 115.2f);//南
            //Effect10km.ShowerAdd(80.69f, 84.85f, 26.218f, 0, 0, 22, "10kmshower", 96, 115.2f);//南
            //Effect20km.ShowerAdd(86.56f, 53.67f, 62.89f, 0, 0, -20, "20kmshower", 60, 72);//南
            //Effect20km.ShowerAdd(96.64f, 53.67f, 45.91f, 0, 0, 0, "20kmshower", 60, 72);//南
            //Effect40km.ShowerAdd(105.7f, 29.1f, 47.78f, 0, 0, 20, "40kmshower", 30, 40);//南
            //Effect40km.ShowerAdd(105.7f, 29.1f, 47.78f, 0, 0, -20, "40kmshower", 30, 40);//南
            //put 南 shower here------------------------------------------

            //put 南東 shower here------------------------------------------
            //Effect5km.ShowerAdd(32.97f, 103.92f, 50.13f, 0, 0, 20, "5kmshower", 120, 140);//南東
            //Effect5km.ShowerAdd(32.97f, 103.92f, 50.13f, 0, 0, 6, "5kmshower", 120, 140);//南東
            //Effect10km.ShowerAdd(34.51f, 84.85f, 77.51f, 0, 0, 7, "10kmshower", 96, 115.2f);//南東
            //Effect10km.ShowerAdd(34.51f, 84.85f, 77.51f, 0, 0, -17, "10kmshower", 96, 115.2f);//南東
            //Effect20km.ShowerAdd(33.06f, 53.67f, 101.75f, 0, 0, 0, "20kmshower", 60, 72);//南東
            //Effect20km.ShowerAdd(62.88f, 53.67f, 86.55f, 0, 0, 20, "20kmshower", 60, 72);//南東
            //Effect40km.ShowerAdd(57.43f, 29.1f, 100.78f, 0, 0, -20, "40kmshower", 30, 40);//南東
            //Effect40km.ShowerAdd(78.415f, 29.1f, 85.473f, 0, 0, 13, "40kmshower", 30, 40);//南東
            //put 南東 shower here------------------------------------------

            //put 東 shower here------------------------------------------
            //Effect5km.ShowerAdd(-12.13f, 103.92f, 58.76f, 0, 0, 8, "5kmshower", 120, 140);//東
            //Effect5km.ShowerAdd(-39.88f, 103.92f, 44.82f, 0, 0, -18, "5kmshower", 120, 140);//東
            //Effect10km.ShowerAdd(-8.87f, 84.85f, 84.38f, 0, 0, 20, "10kmshower", 96, 115.2f);//東
            //Effect10km.ShowerAdd(-8.87f, 84.85f, 84.38f, 0, 0, -4, "10kmshower", 96, 115.2f);//東
            //Effect20km.ShowerAdd(-33.06f, 53.67f, 101.75f, 0, 0, 9, "20kmshower", 60, 72);//東
            //Effect20km.ShowerAdd(-33.06f, 53.67f, 101.75f, 0, 0, -19, "20kmshower", 60, 72);//東
            //Effect40km.ShowerAdd(-30.65f, 29.1f, 111.87f, 0, 0, 4, "40kmshower", 30, 40);//東
            //Effect40km.ShowerAdd(-8.236f, 29.1f, 115.699f, 0, 0, -17, "40kmshower", 30, 40);//東
            //put 東 shower here------------------------------------------

            //put 北東 shower here------------------------------------------
            //Effect5km.ShowerAdd(-44.35f, 103.92f, 40.4f, 0, 0, 8, "5kmshower", 120, 140);//北東
            //Effect5km.ShowerAdd(-58.61f, 103.92f, 12.81f, 0, 0, -18, "5kmshower", 120, 140);//北東
            //Effect10km.ShowerAdd(-66.75f, 84.85f, 52.37f, 0, 0, 14, "10kmshower", 96, 115.2f);//北東
            //Effect10km.ShowerAdd(-80.636f, 84.85f, 26.38f, 0, 0, -18, "10kmshower", 96, 115.2f);//北東
            //Effect20km.ShowerAdd(-86.56f, 53.67f, 62.89f, 0, 0, 29, "20kmshower", 60, 72);//北東
            //Effect20km.ShowerAdd(-100.77f, 53.67f, 35.955f, 0, 0, -29, "20kmshower", 60, 72);//北東
            //Effect40km.ShowerAdd(-100.78f, 29.1f, 57.42f, 0, 0, 14, "40kmshower", 30, 40);//北東
            //Effect40km.ShowerAdd(-104.463f, 29.1f, 50.408f, 0, 0, -12, "40kmshower", 30, 40);//北東
            //put 北東 shower here------------------------------------------

            //put 北西 shower here------------------------------------------
            //Effect5km.ShowerAdd(-20.35f, 103.92f, -56.43f, 0, 0, -18, "5kmshower", 120, 140);//北西
            //Effect5km.ShowerAdd(-20.35f, 103.92f, -56.43f, 0, 0, 0, "5kmshower", 120, 140);//北西
            //Effect10km.ShowerAdd(-68.64f, 84.85f, -49.87f, 0, 0, 24, "10kmshower", 96, 115.2f);//北西
            //Effect10km.ShowerAdd(-54.71f, 84.85f, -64.847f, 0, 0, 0, "10kmshower", 96, 115.2f);//北西
            //Effect20km.ShowerAdd(-75.65f, 53.67f, -75.65f, 0, 0, 29, "20kmshower", 60, 72);//北西
            //Effect20km.ShowerAdd(-51.27f, 53.67f, -93.898f, 0, 0, -3, "20kmshower", 60, 72);//北西
            //Effect40km.ShowerAdd(-57.43f, 29.1f, -100.78f, 0, 0, -24, "40kmshower", 30, 40);//北西
            //Effect40km.ShowerAdd(-57.43f, 29.1f, -100.78f, 0, 0, 24, "40kmshower", 30, 40);//北西
            //Effect80km.ShowerAdd(-81.66f, 14.8f, -86.557f, 0, 0, 30, "80kmshower", 12, 20.8f);//北西
            //Effect80km.ShowerAdd(-72.484f, 14.8f, -94.374f, 0, 0, -20, "80kmshower", 12, 20.8f);//北西
            //put 北西 shower here------------------------------------------

            //put 西 shower here------------------------------------------
            //Effect5km.ShowerAdd(44.35f, 103.92f, -40.4f, 0, 0, -13, "5kmshower", 120, 140);//西
            //Effect5km.ShowerAdd(-12.81f, 103.92f, -58.608f, 0, 0, 13, "5kmshower", 120, 140);//西
            //Effect10km.ShowerAdd(-13.27f, 84.85f, -83.8f, 0, 0, 4, "10kmshower", 96, 115.2f);//西
            //Effect10km.ShowerAdd(7.17f, 84.85f, -84.54f, 0, 0, 20, "10kmshower", 96, 115.2f);//西
            //Effect20km.ShowerAdd(3.87f, 53.67f, -107f, 0, 0, -9, "20kmshower", 60, 72);//西
            //Effect20km.ShowerAdd(3.87f, 53.67f, -107f, 0, 0, 23, "20kmshower", 60, 72);//西
            //Effect40km.ShowerAdd(30.656f, 29.1f, -111.87f, 0, 0, 24, "40kmshower", 30, 40);//西
            //Effect40km.ShowerAdd(60.931f, 29.1f, -98.70f, 0, 0, -14, "40kmshower", 30, 40);//西
            //Effect80km.ShowerAdd(47.13f, 14.8f, -109.26f, 0, 0, -10, "80kmshower", 12, 20.8f);//西
            //Effect80km.ShowerAdd(47.13f, 14.8f, -109.26f, 0, 0, 20, "80kmshower", 12, 20.8f);//西
            //put 西 shower here------------------------------------------
        }
        //シャワー倉庫
        //5km
        Effect5km.ShowerAdd(51.33f, 33.28f, 16.2f, 0, 0, -19, "5kmshower", 137, 137);//南（5kmの基準）
        Effect5km.ShowerAdd(51.33f, 33.28f, 0.2f, 0, 0, 0, "5kmshower", 137, 137);//南南西（5kmの基準）
        Effect5km.ShowerAdd(41.33f, 33.28f, 36.2f, 0, 0, -29, "5kmshower", 137, 137);//南南東（5kmの基準）
        Effect5km.ShowerAdd(51.33f, 33.28f, 6f, 0, 70, 0, "5kmshower", 137, 137);//南南西（5kmの基準）
        Effect5km.ShowerAdd(51.33f, 33.28f, 16.2f, 0, 0, -35, "5kmshower", 137, 137);//南（5kmの基準）
        Effect5km.ShowerAdd(31.33f, 33.28f, 46.2f, 0, 0, 19, "5kmshower", 137, 137);//南南東（5kmの基準）

        //10km
        Effect10km.ShowerAdd(46.2f, 32.28f, 66.33f, 0, 40, -7, "10kmshower", 96, 96);//南南東
        Effect10km.ShowerAdd(86.2f, 32.28f, 0.33f, 0, 60, 17, "10kmshower", 96, 96);//南南西
        Effect10km.ShowerAdd(76.2f, 32.28f, 36.33f, 0, 40, 17, "10kmshower", 96, 96);//南
        Effect10km.ShowerAdd(76.2f, 32.28f, 36.33f, 0, 40, 42, "10kmshower", 96, 96);//南
        Effect10km.ShowerAdd(56.2f, 32.28f, 56.33f, 0, 40, 17, "10kmshower", 96, 96);//南南東
        Effect10km.ShowerAdd(56.2f, 32.28f, 56.33f, 0, 40, 17, "10kmshower", 96, 96);//南南東
        Effect10km.ShowerAdd(86.2f, 32.28f, -10.33f, 0, 60, -37, "10kmshower", 96, 96);//南南西

        //20km
        Effect20km.ShowerAdd(85.46f, 17.91f, -7.18f, 0, 50, -19, "20kmshower", 46, 60);//南南西
        Effect20km.ShowerAdd(85.46f, 11.91f, -7.18f, 0, 50, 29, "20kmshower", 46, 60);//南南西
        Effect20km.ShowerAdd(55.89f, 13.21f, 65.98f, 0, 50, 0, "20kmshower", 46, 60);//南南東
        Effect20km.ShowerAdd(44.88f, 18.21f, 73.98f, 0, 50, -40, "20kmshower", 46, 60);//南南東
        Effect20km.ShowerAdd(44.88f, 17.21f, 73.98f, 0, 50, 20, "20kmshower", 46, 60);//南南東

        //40km
        Effect40km.ShowerAdd(79.3f, 26.5f, -1.04f, 0, -80, -17, "40kmshower", 23, 30);//南南西
        Effect40km.ShowerAdd(39.3f, 17.9f, 69.04f, 0, 30, 37, "40kmshower", 23, 30);//南南東
        Effect40km.ShowerAdd(72f, 6.6f, 33.53f, 0, 30, 37, "40kmshower", 23, 30);//南
        Effect40km.ShowerAdd(63.3f, 6.6f, 47.04f, 0, 30, -27, "40kmshower", 23, 30);//南
        Effect40km.ShowerAdd(72f, 4.6f, 33.53f, 0, 30, 7, "40kmshower", 23, 30);//南
        Effect40km.ShowerAdd(79.3f, 7.5f, -1.04f, 0, -80, 37, "40kmshower", 23, 30);//南南西
    }
}
