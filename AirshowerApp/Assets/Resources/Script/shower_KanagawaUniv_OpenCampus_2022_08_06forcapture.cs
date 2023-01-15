using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;



public class shower_KanagawaUniv_OpenCampus_2022_08_06forcapture : MonoBehaviour
{
    private int flag = 0;
    private static AudioSource audioSource;
    IEnumerator Coroutine;
    // Start is called before the first frame update
    void Start()
    {
        Coroutine = coroutineR();
        StartCoroutine(Coroutine);
        //audioSource = GetComponent<AudioSource>();
        //audioSource.Play();
    }

    void Update()
    {
        if (flag % 2 == 1)
        {
            Debug.Log("コルーチンは新たにスタートしました");
            //SetRightEyeHaikei.flag_H++;
            //SetLeftEyeHaikei.flag_H++;
            //SetRightEyeHaikei.flag_S++;
            flag++;
        }
    }

    // Update is called once per frame
    private IEnumerator coroutineR()
    {
        while (true)
        {
            //if (ShowerManager.shower_coroutine_flag % 2 == 1)
            //{
            //    audioSource.Play();
            //    ShowerManager.shower_coroutine_flag++;
            //}

            int temp_x = -1;
            //int temp_y = -1;
            int new_x = 1;
            int new_y = 1;
            int flag_y = -1;

            yield return new WaitForSeconds(13.0f);//小学生用ナレーションのシャワーのイントロダクションまで待つ(小学生用ナレーション改）

            EffectIntro10km.ShowerAdd(68.64f, 84.85f, 49.87f, 0, 0, -17, "Introshower_10km", 96, 115.2f);//南
            //Effect2.ShowerAdd(55.33f, 33.28f, 16.2f, 0, 70, -19, "quest2_showerL_introduction", 137, 137);//南（5kmの基準）
            yield return new WaitForSeconds(18.6f);

            EffectIntro20km.ShowerAdd(-33.06f, 53.67f, 101.75f, 0, 0, -19, "Introshower_20km", 60, 72);//東

            yield return new WaitForSeconds(18f);

            EffectIntro5km.ShowerAdd(53.62f, 103.92f, 26.93f, 0, 0, 10, "Introshower_5km", 120, 140);//南（5kmの基準）

            yield return new WaitForSeconds(13.9f);//小学生用ナレーションが終わるまで待つ

            //小学生ナレーション用
            //10km先
            Effect10km.ShowerAdd(68.64f, 84.85f, 49.87f, 0, 0, -17, "10kmshower", 96, 115.2f);//南
            yield return new WaitForSeconds(5.3f);//10km先～20km先の間の時間

            //20km先
            Effect20km.ShowerAdd(96.64f, 53.67f, 45.91f, 0, 0, 0, "20kmshower", 60, 72);//南
            yield return new WaitForSeconds(5.1f);//5s待機

            //40km先
            Effect40km.ShowerAdd(105.7f, 29.1f, 47.78f, 0, 0, -20, "40kmshower", 30, 40);//南
            yield return new WaitForSeconds(5f);//5s待機

            //80km先
            Effect80km.ShowerAdd(119f, 14.8f, 0f, 0, 0, 30, "80kmshower", 12, 20.8f);//南西

            //チュートリアル終了後の最初のシャワーの降ってくるタイミング
            yield return new WaitForSeconds(33f);//5s待機

            //背景切り替えのタイミングの変更を忘れない
            yield return new WaitForSeconds(1f);//5s待機
            while (true)
            {
                //if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                //{
                //    break;//シャワーコルーチン終了
                //}



                UnityEngine.Random.InitState(System.DateTime.Now.Millisecond);//シード値を現在時刻に
                new_x = UnityEngine.Random.Range(0, 7);

                if (new_x == temp_x)//次に降るシャワーが前のシャワーと同じ方向だった場合、別のところに降らせる
                {
                    new_x++;
                    if (new_x == 7)
                    {
                        new_x = 0;
                    }
                }

                temp_x = new_x;
                Debug.Log("乱数生成成功");
                Debug.Log(new_x);

                while (true)
                {
                    if (HaikeiManager.haikei_flag == 0)
                    {
                        break;
                    }

                    else if (HaikeiManager.haikei_flag == 1)
                    {
                        yield return new WaitForSeconds(0.1f);
                        if (HaikeiManager.haikei_flag == 0)
                        {
                            break;
                        }
                    }
                }

                switch (new_x)//方角のrand
                {
                    case 0://南
                        Debug.Log("南に降ります");
                        UnityEngine.Random.InitState(System.DateTime.Now.Millisecond);//シード値を現在時刻に
                        new_y = UnityEngine.Random.Range(0, 8);
                        switch (new_y)
                        {
                            case 0:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(53.62f, 103.92f, 26.93f, 0, 0, 10, "5kmshower", 120, 140);//南
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//トリガーが引かれたら呼び出す
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 1:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(32.97f, 103.92f, 50.132f, 0, 0, -17, "5kmshower", 120, 140);//南
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//トリガーが引かれたら呼び出す
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 2:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(68.64f, 84.85f, 49.87f, 0, 0, -17, "10kmshower", 96, 115.2f);//南
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 3:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(80.69f, 84.85f, 26.218f, 0, 0, 22, "10kmshower", 96, 115.2f);//南
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 4:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(86.56f, 53.67f, 62.89f, 0, 0, -20, "20kmshower", 60, 72);//南
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 5:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(96.64f, 53.67f, 45.91f, 0, 0, 0, "20kmshower", 60, 72);//南
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 6:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(105.7f, 29.1f, 47.78f, 0, 0, 20, "40kmshower", 30, 40);//南
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 7:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(105.7f, 29.1f, 47.78f, 0, 0, -20, "40kmshower", 30, 40);//南
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            default:
                                Debug.Log("failed");
                                break;
                        }
                        break;

                    case 1://東
                        Debug.Log("東に降ります");
                        UnityEngine.Random.InitState(System.DateTime.Now.Millisecond);//シード値を現在時刻に
                        new_y = UnityEngine.Random.Range(0, 8);
                        switch (new_y)
                        {
                            case 0:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(-12.13f, 103.92f, 58.76f, 0, 0, 8, "5kmshower", 120, 140);//東
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 1:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(-39.88f, 103.92f, 44.82f, 0, 0, -18, "5kmshower", 120, 140);//東
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 2:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(-8.87f, 84.85f, 84.38f, 0, 0, 20, "10kmshower", 96, 115.2f);//東
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 3:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(-8.87f, 84.85f, 84.38f, 0, 0, -4, "10kmshower", 96, 115.2f);//東
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 4:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(-33.06f, 53.67f, 101.75f, 0, 0, 9, "20kmshower", 60, 72);//東
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 5:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(-33.06f, 53.67f, 101.75f, 0, 0, -19, "20kmshower", 60, 72);//東
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 6:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(-30.65f, 29.1f, 111.87f, 0, 0, 4, "40kmshower", 30, 40);//東
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 7:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(-8.236f, 29.1f, 115.699f, 0, 0, -17, "40kmshower", 30, 40);//東
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            default:
                                Debug.Log("failed");
                                break;
                        }
                        break;

                    case 2://西
                        Debug.Log("西に降ります");
                        UnityEngine.Random.InitState(System.DateTime.Now.Millisecond);//シード値を現在時刻に
                        new_y = UnityEngine.Random.Range(0, 10);
                        switch (new_y)
                        {
                            case 0:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(44.35f, 103.92f, -40.4f, 0, 0, -13, "5kmshower", 120, 140);//西
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 1:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(-12.81f, 103.92f, -58.608f, 0, 0, 13, "5kmshower", 120, 140);//西
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 2:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(-13.27f, 84.85f, -83.8f, 0, 0, 4, "10kmshower", 96, 115.2f);//西
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 3:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(7.17f, 84.85f, -84.54f, 0, 0, 20, "10kmshower", 96, 115.2f);//西
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 4:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(3.87f, 53.67f, -107f, 0, 0, -9, "20kmshower", 60, 72);//西
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 5:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(3.87f, 53.67f, -107f, 0, 0, 23, "20kmshower", 60, 72);//西
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 6:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(30.656f, 29.1f, -111.87f, 0, 0, 24, "40kmshower", 30, 40);//西
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 7:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(60.931f, 29.1f, -98.70f, 0, 0, -14, "40kmshower", 30, 40);//西
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 8:
                                if (flag_y == 80)
                                {
                                    continue;
                                }
                                Effect80km.ShowerAdd(47.13f, 14.8f, -109.26f, 0, 0, -10, "80kmshower", 12, 20.8f);//西
                                flag_y = 80;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 9:
                                if (flag_y == 80)
                                {
                                    continue;
                                }
                                Effect80km.ShowerAdd(47.13f, 14.8f, -109.26f, 0, 0, 20, "80kmshower", 12, 20.8f);//西
                                flag_y = 80;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            default:
                                Debug.Log("failed");
                                break;
                        }
                        break;

                    case 3://南西
                        Debug.Log("南西に降ります");
                        UnityEngine.Random.InitState(System.DateTime.Now.Millisecond);//シード値を現在時刻に
                        new_y = UnityEngine.Random.Range(0, 10);
                        switch (new_y)
                        {
                            case 0:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(56.75f, 103.92f, 19.49f, 0, 0, -17, "5kmshower", 120, 140);//南西
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 1:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(57.367f, 103.92f, -17.59f, 0, 0, 14, "5kmshower", 120, 140);//南西
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 2:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(84.85f, 84.85f, 0f, 0, 0, -7, "10kmshower", 96, 115.2f);//南西
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 3:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(83.219f, 84.85f, 16.55f, 0, 0, -16, "10kmshower", 96, 115.2f);//南西
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 4:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(107f, 53.67f, 0f, 0, 0, 3, "20kmshower", 60, 72);//南西
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 5:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(103.354f, 53.67f, -27.693f, 0, 0, 23, "20kmshower", 60, 72);//南西
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 6:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(116f, 29.1f, 0f, 0, 0, -10, "40kmshower", 30, 40);//南西
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 7:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(116f, 29.1f, 0f, 0, 0, 18, "40kmshower", 30, 40);//南西
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 8:
                                if (flag_y == 80)
                                {
                                    continue;
                                }
                                Effect80km.ShowerAdd(119f, 14.8f, 0f, 0, 0, 30, "80kmshower", 12, 20.8f);//南西
                                flag_y = 80;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 9:
                                if (flag_y == 80)
                                {
                                    continue;
                                }
                                Effect80km.ShowerAdd(119f, 14.8f, 0f, 0, 0, -20, "80kmshower", 12, 20.8f);//南西
                                flag_y = 80;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            default:
                                Debug.Log("failed");
                                break;
                        }
                        break;

                    case 4://北西
                        Debug.Log("北西に降ります");
                        UnityEngine.Random.InitState(System.DateTime.Now.Millisecond);//シード値を現在時刻に
                        new_y = UnityEngine.Random.Range(0, 10);
                        switch (new_y)
                        {
                            case 0:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(-20.35f, 103.92f, -56.43f, 0, 0, -18, "5kmshower", 120, 140);//北西
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 1:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(-20.35f, 103.92f, -56.43f, 0, 0, 0, "5kmshower", 120, 140);//北西
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 2:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(-68.64f, 84.85f, -49.87f, 0, 0, 24, "10kmshower", 96, 115.2f);//北西
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 3:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(-54.71f, 84.85f, -64.847f, 0, 0, 0, "10kmshower", 96, 115.2f);//北西
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 4:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(-75.65f, 53.67f, -75.65f, 0, 0, 29, "20kmshower", 60, 72);//北西
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 5:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(-51.27f, 53.67f, -93.898f, 0, 0, -3, "20kmshower", 60, 72);//北西
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 6:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(-57.43f, 29.1f, -100.78f, 0, 0, -24, "40kmshower", 30, 40);//北西
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 7:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(-57.43f, 29.1f, -100.78f, 0, 0, 24, "40kmshower", 30, 40);//北西
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 8:
                                if (flag_y == 80)
                                {
                                    continue;
                                }
                                Effect80km.ShowerAdd(-81.66f, 14.8f, -86.557f, 0, 0, 30, "80kmshower", 12, 20.8f);//北西
                                flag_y = 80;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 9:
                                if (flag_y == 80)
                                {
                                    continue;
                                }
                                Effect80km.ShowerAdd(-72.484f, 14.8f, -94.374f, 0, 0, -20, "80kmshower", 12, 20.8f);//北西
                                flag_y = 80;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            default:
                                Debug.Log("failed");
                                break;
                        }
                        break;


                    case 5://南東
                        Debug.Log("南東に降ります");
                        UnityEngine.Random.InitState(System.DateTime.Now.Millisecond);//シード値を現在時刻に
                        new_y = UnityEngine.Random.Range(0, 8);
                        switch (new_y)
                        {
                            case 0:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(32.97f, 103.92f, 50.13f, 0, 0, 20, "5kmshower", 120, 140);//南東
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 1:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(32.97f, 103.92f, 50.13f, 0, 0, 6, "5kmshower", 120, 140);//南東
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 2:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(34.51f, 84.85f, 77.51f, 0, 0, 7, "10kmshower", 96, 115.2f);//南東
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 3:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(34.51f, 84.85f, 77.51f, 0, 0, -17, "10kmshower", 96, 115.2f);//南東
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 4:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(33.06f, 53.67f, 101.75f, 0, 0, 0, "20kmshower", 60, 72);//南東
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 5:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(62.88f, 53.67f, 86.55f, 0, 0, 20, "20kmshower", 60, 72);//南東
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 6:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(57.43f, 29.1f, 100.78f, 0, 0, -20, "40kmshower", 30, 40);//南東
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 7:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(78.415f, 29.1f, 85.473f, 0, 0, 13, "40kmshower", 30, 40);//南東
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            default:
                                Debug.Log("failed");
                                break;
                        }
                        break;

                    case 6://北東
                        Debug.Log("北東に降ります");
                        UnityEngine.Random.InitState(System.DateTime.Now.Millisecond);//シード値を現在時刻に
                        new_y = UnityEngine.Random.Range(0, 8);
                        switch (new_y)
                        {
                            case 0:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(-44.35f, 103.92f, 40.4f, 0, 0, 8, "5kmshower", 120, 140);//北東
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 1:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(-58.61f, 103.92f, 12.81f, 0, 0, -18, "5kmshower", 120, 140);//北東
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 2:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(-66.75f, 84.85f, 52.37f, 0, 0, 14, "10kmshower", 96, 115.2f);//北東
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 3:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(-80.636f, 84.85f, 26.38f, 0, 0, -18, "10kmshower", 96, 115.2f);//北東
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 4:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(-86.56f, 53.67f, 62.89f, 0, 0, 29, "20kmshower", 60, 72);//北東
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 5:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(-100.77f, 53.67f, 35.955f, 0, 0, -29, "20kmshower", 60, 72);//北東
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 6:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(-100.78f, 29.1f, 57.42f, 0, 0, 14, "40kmshower", 30, 40);//北東
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            case 7:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(-104.463f, 29.1f, 50.408f, 0, 0, -12, "40kmshower", 30, 40);//北東
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s待機
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//シャワーコルーチン終了
                                    }
                                }
                                break;

                            default:
                                Debug.Log("failed");
                                break;
                        }
                        break;

                    default:
                        Debug.Log("failed");
                        break;


                }

                if (ShowerManager.shower_coroutine_flag % 2 == 1)//通常ループ(7秒間隔でシャワー降ってくる）から抜ける
                {
                    break;
                }

            }
            continue;
        }
    }

}