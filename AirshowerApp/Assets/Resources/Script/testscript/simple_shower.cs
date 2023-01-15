using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class simple_shower : MonoBehaviour
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


            //test here---------------------------------------------------
            //for(int i = 0; i < 9; i++)
            //{
            //    //Effect.ShowerAdd(68f, 5.71f, 27.7f, 0, 40, 10, "quest2_showerLL", 46, 60);//南
            //    Effect.ShowerAdd(68f, 12.91f, 40.53f, 0, 30, 40, "quest2_showerLL", 46, 60);//南
            //    Effect.ShowerAdd(76f, 12.91f, 25.53f, 0, 30, 44, "quest2_showerLL", 46, 60);//南
            //    //Effect.ShowerAdd(72f, 4.6f, 33.53f, 0, 30, 7, "quest2_showerLLL_40kmaudio", 23, 30);//南
            //    //Effect.ShowerAdd(72f, 6.6f, 33.53f, 0, 30, 37, "quest2_showerLLL_40kmaudio", 23, 30);//南
            //    //Effect.ShowerAdd(63.3f, 6.6f, 47.04f, 0, 30, -27, "quest2_showerLLL_40kmaudio", 23, 30);//南

            //    Effect.ShowerAdd(84f, 23.91f, 20.53f, 0, 50, -39, "quest2_showerLL", 46, 60);//南南西
            //    //Effect.ShowerAdd(85.46f, 17.91f, -7.18f, 0, 50, -19, "quest2_showerLL", 46, 60);//南南西
            //    //Effect.ShowerAdd(85.46f, 11.91f, -7.18f, 0, 50, 29, "quest2_showerLL", 46, 60);//南南西
            //    //Effect.ShowerAdd(79.3f, 7.5f, -1.04f, 0, -80, 37, "quest2_showerLLL_40kmaudio", 23, 30);//南南西
            //    //Effect.ShowerAdd(79.3f, 5.5f, -1.04f, 0, -80, -17, "quest2_showerLLL_40kmaudio", 23, 30);//南南西
            //    Effect.ShowerAdd(79.3f, 7.3f, 5.04f, 0, -80, -32, "quest2_showerLLL_40kmaudio", 23, 30);//南南西

            //    Effect.ShowerAdd(55.89f, 13.21f, 65.98f, 0, 50, 0, "quest2_showerLL", 46, 60);//南南東
            //    //Effect.ShowerAdd(44.88f, 17.21f, 73.98f, 0, 50, 20, "quest2_showerLL", 46, 60);//南南東
            //    //Effect.ShowerAdd(44.88f, 18.21f, 73.98f, 0, 50, -40, "quest2_showerLL", 46, 60);//南南東
            //    Effect.ShowerAdd(39.3f, 6.3f, 69.04f, 0, 30, -27, "quest2_showerLLL_40kmaudio", 23, 30);//南南東
            //    Effect.ShowerAdd(39.3f, 5f, 69.04f, 0, 30, 7, "quest2_showerLLL_40kmaudio", 23, 30);//南南東
            //    //Effect.ShowerAdd(39.3f, 7.9f, 69.04f, 0, 30, 37, "quest2_showerLLL_40kmaudio", 23, 30);//南南東
            //    yield return new WaitForSeconds(5.1f);//8s待機
            //}
            //------------------------------------------------------------

            //20 or 40km shower for rotation-------------------------------------------
            yield return new WaitForSeconds(1.0f);//8s待機

            Effect.ShowerAdd(68f, 5.71f, 27.7f, 0, 40, 10, "quest2_showerLL", 46, 60);//南
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(39.3f, 7.9f, 69.04f, 0, 30, 37, "quest2_showerLLL_40kmaudio", 23, 30);//南南東
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(-0.48f, 9.51f, 79.44f, 0, 20, -19, "quest2_showerLL", 46, 60);//南南西
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(-33.14f, 18.53f, 84.55f, 0, 0, 19, "quest2_showerLL", 46, 60);//南南西
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(-50f, 6.6f, 50.53f, 0, 30, 37, "quest2_showerLLL_40kmaudio", 23, 30);//南
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(85.46f, 11.91f, -7.18f, 0, 50, 29, "quest2_showerLL", 46, 60);//南南西
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(55.89f, 13.21f, 65.98f, 0, 50, 0, "quest2_showerLL", 46, 60);//南南東
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(63.3f, 6.6f, 47.04f, 0, 30, -27, "quest2_showerLLL_40kmaudio", 23, 30);//南
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(44.88f, 18.21f, 73.98f, 0, 50, -40, "quest2_showerLL", 46, 60);//南南東
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(72f, 4.6f, 33.53f, 0, 30, 7, "quest2_showerLLL_40kmaudio", 23, 30);//南
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(79.3f, 7.5f, -1.04f, 0, -80, 37, "quest2_showerLLL_40kmaudio", 23, 30);//南南西
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(44.88f, 17.21f, 73.98f, 0, 50, 20, "quest2_showerLL", 46, 60);//南南東
            yield return new WaitForSeconds(7.1f);//8s待機
            //20 or 40km shower for rotation-------------------------------------------

            //20 or 40km shower-------------------------------------------
            yield return new WaitForSeconds(1.0f);//8s待機

            Effect.ShowerAdd(68f, 5.71f, 27.7f, 0, 40, 10, "quest2_showerLL", 46, 60);//南
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(79.3f, 5.5f, -1.04f, 0, -80, -17, "quest2_showerLLL_40kmaudio", 23, 30);//南南西
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(39.3f, 7.9f, 69.04f, 0, 30, 37, "quest2_showerLLL_40kmaudio", 23, 30);//南南東
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(85.46f, 17.91f, -7.18f, 0, 50, -19, "quest2_showerLL", 46, 60);//南南西
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(72f, 6.6f, 33.53f, 0, 30, 37, "quest2_showerLLL_40kmaudio", 23, 30);//南
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(85.46f, 11.91f, -7.18f, 0, 50, 29, "quest2_showerLL", 46, 60);//南南西
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(55.89f, 13.21f, 65.98f, 0, 50, 0, "quest2_showerLL", 46, 60);//南南東
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(63.3f, 6.6f, 47.04f, 0, 30, -27, "quest2_showerLLL_40kmaudio", 23, 30);//南
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(44.88f, 18.21f, 73.98f, 0, 50, -40, "quest2_showerLL", 46, 60);//南南東
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(72f, 4.6f, 33.53f, 0, 30, 7, "quest2_showerLLL_40kmaudio", 23, 30);//南
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(79.3f, 7.5f, -1.04f, 0, -80, 37, "quest2_showerLLL_40kmaudio", 23, 30);//南南西
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(44.88f, 17.21f, 73.98f, 0, 50, 20, "quest2_showerLL", 46, 60);//南南東
            yield return new WaitForSeconds(7.1f);//8s待機
            //20 or 40km shower-------------------------------------------


            //5 or 10km shower--------------------------------------------
            yield return new WaitForSeconds(1.0f);//8s待機

            Effect.ShowerAdd(51.33f, 33.28f, 16.2f, 0, 70, -19, "quest2_showerL", 137, 137);//南（5kmの基準）
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(46.2f, 32.28f, 66.33f, 0, 40, -7, "quest2_showerL_10kmaudio", 96, 96);//南南東
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(86.2f, 32.28f, 0.33f, 0, 60, 17, "quest2_showerL_10kmaudio", 96, 96);//南南西
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(51.33f, 33.28f, 0.2f, 0, 70, 0, "quest2_showerL", 137, 137);//南南西（5kmの基準）
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(41.33f, 33.28f, 36.2f, 0, 40, -29, "quest2_showerL", 137, 137);//南南東（5kmの基準）
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(76.2f, 32.28f, 36.33f, 0, 40, 17, "quest2_showerL_10kmaudio", 96, 96);//南
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(51.33f, 33.28f, 6f, 0, 70, 10, "quest2_showerL", 137, 137);//南南西（5kmの基準）
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(76.2f, 32.28f, 36.33f, 0, 40, 42, "quest2_showerL_10kmaudio", 96, 96);//南
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(56.2f, 32.28f, 56.33f, 0, 40, 17, "quest2_showerL_10kmaudio", 96, 96);//南南東
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(51.33f, 33.28f, 16.2f, 0, 70, -35, "quest2_showerL", 137, 137);//南（5kmの基準）
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(31.33f, 33.28f, 46.2f, 0, 70, 19, "quest2_showerL", 137, 137);//南南東（5kmの基準）
            yield return new WaitForSeconds(7.1f);//8s待機

            Effect.ShowerAdd(86.2f, 32.28f, -10.33f, 0, 60, -37, "quest2_showerL_10kmaudio", 96, 96);//南南西
            yield return new WaitForSeconds(7.1f);//8s待機
            //5 or 10km shower--------------------------------------------
        }

    }
}
