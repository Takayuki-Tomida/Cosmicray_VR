using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//このスクリプトはSphereLにアタッチする
//Earlymorning(255)→(255→1)→Evening(1)→(1→255)→(255→1)→Earlymorning(1)→(1→255)→最初に戻る

public class ChangeHaikei_forapp : MonoBehaviour
{
    public Material[] mat;
    public int flg = 0;
    public int laps = 0;
    private int i = 0;

    public static int flag_H = 1;//背景の切り替え方式（2種類：16秒間隔、144秒間隔）
    public static int flag_S = 0;//1になったら通常ループに移動

    public int cnt = 0;

    // Start is called before the first frame update
    void Start()
    {

        IEnumerator coroutine = SetMat();
        StartCoroutine(coroutine);
    }


    IEnumerator SetMat()
    {
        GameObject SphereL = GameObject.Find("SphereL");
        
        GameObject SphereL3 = GameObject.Find("SphereL3");
        
        GameObject SphereR = GameObject.Find("SphereR");
        
        GameObject SphereR3 = GameObject.Find("SphereR3");
        

        Material EarlyMorning_Left = Resources.Load("Texture/New_Texture/" + "EarlyMorning_Left") as Material;
        
        Material Noon_Left = Resources.Load("Texture/New_Texture/" + "Noon_Left") as Material;
        
        Material Evening_Left = Resources.Load("Texture/New_Texture/" + "Evening_Left") as Material;
        
        Material LaterEvening_Left = Resources.Load("Texture/New_Texture/" + "LaterEvening_Left") as Material;
        
        Material EarlyMorning_Right = Resources.Load("Texture/New_Texture/" + "EarlyMorning_Right") as Material;
        
        Material Noon_Right = Resources.Load("Texture/New_Texture/" + "Noon_Right") as Material;
        
        Material Evening_Right = Resources.Load("Texture/New_Texture/" + "Evening_Right") as Material;
        
        Material LaterEvening_Right = Resources.Load("Texture/New_Texture/" + "LaterEvening_Right") as Material;
        
        while (true)
        {
            if (laps == 0 & i == 0)
            {
                SphereL.GetComponent<Renderer>().material = EarlyMorning_Left;
                
                SphereR.GetComponent<Renderer>().material = EarlyMorning_Right;
                
                SphereL3.GetComponent<Renderer>().material = Noon_Left;
                
                SphereR3.GetComponent<Renderer>().material = Noon_Right;
                

                SphereL.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.99f);//EarlyMorningは初期状態で透明度1なので最初のみ
                
                SphereR.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.99f);//EarlyMorningは初期状態で透明度1なので最初のみ
                
            }

            yield return Touka(flg, laps, SphereL,  SphereL3, SphereR, SphereR3,  EarlyMorning_Left, Noon_Left,  Evening_Left, LaterEvening_Left, EarlyMorning_Right,  Noon_Right, Evening_Right, LaterEvening_Right);
            //gameObject.GetComponent<SetMaterialX>().enabled = false;
            i++;
            flg++;
            cnt++;
            if (i == 2)
            {
                i = 0;
                laps++;
                //flg += 1;
            }
        }
    }

    public IEnumerator Touka(int flag, int laps, GameObject SphereL, GameObject SphereL3,  GameObject SphereR, GameObject SphereR3,  Material EarlyMorning_Left, Material Noon_Left,Material Evening_Left,  Material LaterEvening_Left, Material EarlyMorning_Right, Material Noon_Right, Material Evening_Right,  Material LaterEvening_Right)
    {
        //GameObject SphereL3 = GameObject.Find("SphereL3");
        //Material Noon_Left = Resources.Load("Texture/New_Texture/" + "Noon_Left") as Material;
        //Material LaterEvening_Left = Resources.Load("Texture/New_Texture/" + "LaterEvening_Left") as Material;

        float t = 0.005f;
        if (flag == 0 & laps == 0)//初期条件
        {
            int s = 0;
            int u = 0;

            while (s <= 140 || u <= 1420)
            {
                Debug.Log("イントロのループ");
                switch (flag_H % 2)
                {
                    case 0:
                        for (int i = 0; i < 140; i++)
                        {
                            if (flag_H % 2 == 1)//flag_H=1に変化していた場合、チュートリアル用のfor文へ
                            {
                                goto case 1;
                                //break;
                            }
                            s++;
                            yield return new WaitForSeconds(0.1f);
                            Debug.Log("s = " + s);
                            if (s == 140)
                            {
                                Debug.Log("通常変化開始");
                                goto case 2;
                            }
                        }
                        break;

                    case 1:
                        for (int j = 0; j < 1420; j++)
                        {
                            u++;

                            //uが216を超えるとキーボードE入力（ナレーション再開トリガー）を受け付けるようになる
                            //トリガー入力時の各パラメーターの変化
                            //1) シャワーが描画されていないタイミングでトリガーを引いた場合
                            //flag_H++ →　すぐにチュートリアル用の背景切り替え(124s)に変更する。
                            //2) シャワーが描画されているタイミングでトリガーを引いた場合
                            //audio_length_flag++ →　シャワー音声の残りの再生時間を計算し、その時間が経過したらflag_H = 2
                            //つまり時間がある程度かかるため下のif文には引っかからない

                            if (flag_H % 2 == 0 && 1080 <= u && 1420 >= u)//flag_Hが奇数でナレーション部分が終わりかつ背景が切り替わっていない場合
                            {
                                flag_H++;
                                u = 0;
                                Debug.Log("最初のイントロ直後にボタンが押されました");
                                Debug.Log("flag_H = " + flag_H);
                                break;
                            }

                            yield return new WaitForSeconds(0.1f);
                            Debug.Log("u = " + u);

                            if (u == 1420)
                            {
                                Debug.Log("ナレーション用背景変化開始");
                                flag_H++;//通常ループに入る
                                goto case 2;
                            }
                        }
                        continue;

                    case 2:
                        s = 0;
                        u = 0;

                        //HaikeiManager.haikei_flag = 1;
                        SphereL3.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1f);
                        
                        SphereR3.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1f);
                        
                        yield return new WaitForSeconds(2f);
                        if (cnt == 0)
                        {
                            for (int i = 0; i <= 120; i++)
                            {
                                SphereL.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, t);
                                
                                SphereR.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, t);
                                

                                //SphereL3.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.02f);
                                //SphereL4.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.02f);
                                //SphereR3.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.02f);
                                //SphereR4.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.02f);

                                if (i == 40)
                                {
                                    t = 0.01f;
                                    //HaikeiManager.haikei_flag = 0;
                                }
                                yield return new WaitForSeconds(0.03f);
                            }
                        }

                        t = 0.005f;
                        break;

                    default:

                        s = 0;
                        u = 0;
                        break;

                }


                break;
            }




            //gameObject.GetComponent<SetMaterialX>().enabled = false;

        }

        else//ナレーション終了後の動き
        {

            int s = 0;
            int u = 0;
            //次に進むかどうか
            while (s <= 140 || u <= 1420)
            {
                Debug.Log("2回目のループ");
                switch (flag_H % 2)
                {
                    case 0:
                        for (int i = 0; i < 140; i++)
                        {
                            if (flag_H % 2 == 1)//flag_H=1に変化していた場合、チュートリアル用のfor文へ
                            {
                                goto case 1;
                                //break;
                            }
                            s++;
                            yield return new WaitForSeconds(0.1f);
                            Debug.Log("s = " + s);
                            if (s == 140)
                            {
                                Debug.Log("通常変化開始");
                                goto case 2;
                            }
                        }
                        break;

                    case 1:
                        for (int j = 0; j < 1420; j++)
                        {
                            u++;

                            //uが216を超えるとキーボードE入力（ナレーション再開トリガー）を受け付けるようになる
                            //トリガー入力時の各パラメーターの変化
                            //1) シャワーが描画されていないタイミングでトリガーを引いた場合
                            //flag_H++ →　すぐにチュートリアル用の背景切り替え(124s)に変更する。
                            //2) シャワーが描画されているタイミングでトリガーを引いた場合
                            //audio_length_flag++ →　シャワー音声の残りの再生時間を計算し、その時間が経過したらflag_H = 2
                            //つまり時間がある程度かかるため下のif文には引っかからない

                            if (flag_H % 2 == 0 && 1080 <= u && 1420 >= u)//flag_Hが奇数でナレーション部分が終わりかつ背景が切り替わっていない場合
                            {
                                flag_H++;
                                u = 0;
                                Debug.Log("最初のイントロ直後にボタンが押されました");

                                break;
                            }

                            yield return new WaitForSeconds(0.1f);
                            Debug.Log("u = " + u);

                            if (u == 1420)
                            {
                                Debug.Log("ナレーション用背景変化開始");
                                flag_H++;
                                goto case 2;
                            }
                        }
                        continue;

                    case 2:
                        s = 0;
                        u = 0;

                        //HaikeiManager.haikei_flag = 1;

                        yield return new WaitForSeconds(2f);

                        if (flg % 2 == 1)
                        {
                            SphereL.GetComponent<Renderer>().material = Evening_Left;
                            
                            SphereR.GetComponent<Renderer>().material = Evening_Right;
                            
                        }

                        else
                        {
                            SphereL.GetComponent<Renderer>().material = EarlyMorning_Left;
                           
                            SphereR.GetComponent<Renderer>().material = EarlyMorning_Right;
                            
                        }


                        SphereL.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 0f);
                        
                        SphereR.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 0f);
                        

                        SphereL3.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);
                        
                        SphereR3.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);
                        

                        Debug.Log(SphereL.GetComponent<Renderer>().material.color);
                        Debug.Log(SphereL3.GetComponent<Renderer>().material.color);

                        if (flg % 2 == 1)
                        {
                            for (int i = 0; i <= 120; i++)//徐々に不透明にk
                            {
                                SphereL.GetComponent<Renderer>().material.color += new Color(0, 0, 0, t);
                               
                                SphereR.GetComponent<Renderer>().material.color += new Color(0, 0, 0, t);
                                

                                //SphereL3.GetComponent<Renderer>().material.color -= new Color(0f, 0f, 0f, 0.02f);
                                //SphereL4.GetComponent<Renderer>().material.color -= new Color(0f, 0f, 0f, 0.02f);
                                //SphereR3.GetComponent<Renderer>().material.color -= new Color(0f, 0f, 0f, 0.02f);
                                //SphereR4.GetComponent<Renderer>().material.color -= new Color(0f, 0f, 0f, 0.02f);
                                if (i == 40)
                                {
                                    t = 0.01f;
                                    //HaikeiManager.haikei_flag = 0;
                                }
                                yield return new WaitForSeconds(0.03f);
                            }
                        }

                        else
                        {
                            t = 0.001f;
                            for (int i = 0; i <= 270; i++)//徐々に不透明にk
                            {
                                SphereL.GetComponent<Renderer>().material.color += new Color(0, 0, 0, t);
                                
                                SphereR.GetComponent<Renderer>().material.color += new Color(0, 0, 0, t);
                                

                                //SphereL3.GetComponent<Renderer>().material.color -= new Color(0f, 0f, 0f, 0.02f);
                                //SphereL4.GetComponent<Renderer>().material.color -= new Color(0f, 0f, 0f, 0.02f);
                                //SphereR3.GetComponent<Renderer>().material.color -= new Color(0f, 0f, 0f, 0.02f);
                                //SphereR4.GetComponent<Renderer>().material.color -= new Color(0f, 0f, 0f, 0.02f);
                                if (i == 80)
                                {
                                    t = 0.002f;
                                }
                                if (i == 140)
                                {
                                    t = 0.004f;
                                }
                                if (i == 200)
                                {
                                    t = 0.008f;
                                }
                                yield return new WaitForSeconds(0.016f);
                            }
                        }

                        t = 0.005f;
                        break;

                    default:

                        s = 0;
                        u = 0;
                        break;

                }


                break;
            }

            if (flag % 2 == 1)
            {
                //SphereL3.GetComponent<Renderer>().material = LaterEvening_Left;
            }
            else if (flag % 2 == 0)
            {

                //SphereL3.GetComponent<Renderer>().material = Noon_Left;
            }

            //次に進むかどうか
            while (s <= 140 || u <= 1420)
            {
                Debug.Log("3回目のループ");
                switch (flag_H % 2)
                {
                    case 0:
                        for (int i = 0; i < 140; i++)
                        {
                            if (flag_H % 2 == 1)//flag_H=1に変化していた場合、チュートリアル用のfor文へ
                            {
                                goto case 1;
                                //break;
                            }
                            s++;
                            yield return new WaitForSeconds(0.1f);
                            Debug.Log("s = " + s);
                            if (s == 140)
                            {
                                Debug.Log("通常変化開始");
                                goto case 2;
                            }
                        }
                        break;

                    case 1:
                        for (int j = 0; j < 1420; j++)
                        {
                            u++;

                            //uが216を超えるとキーボードE入力（ナレーション再開トリガー）を受け付けるようになる
                            //トリガー入力時の各パラメーターの変化
                            //1) シャワーが描画されていないタイミングでトリガーを引いた場合
                            //flag_H++ →　すぐにチュートリアル用の背景切り替え(124s)に変更する。
                            //2) シャワーが描画されているタイミングでトリガーを引いた場合
                            //audio_length_flag++ →　シャワー音声の残りの再生時間を計算し、その時間が経過したらflag_H = 2
                            //つまり時間がある程度かかるため下のif文には引っかからない

                            if (flag_H % 2 == 0 && 1080 <= u && 1420 >= u)//flag_Hが奇数でナレーション部分が終わりかつ背景が切り替わっていない場合
                            {
                                flag_H++;
                                u = 0;
                                Debug.Log("最初のイントロ直後にボタンが押されました");

                                break;
                            }

                            yield return new WaitForSeconds(0.1f);
                            Debug.Log("u = " + u);

                            if (u == 1420)
                            {
                                Debug.Log("ナレーション用背景変化開始");
                                flag_H++;
                                goto case 2;
                            }
                        }
                        continue;

                    case 2:
                        s = 0;
                        u = 0;

                        //HaikeiManager.haikei_flag = 1;
                        yield return new WaitForSeconds(2f);

                        if (flg % 2 == 1)
                        {
                            SphereL3.GetComponent<Renderer>().material = LaterEvening_Left;
                           
                            SphereR3.GetComponent<Renderer>().material = LaterEvening_Right;
                            
                        }
                        else
                        {
                            SphereL3.GetComponent<Renderer>().material = Noon_Left;
                            
                            SphereR3.GetComponent<Renderer>().material = Noon_Right;
                            
                        }

                        //SphereL.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);
                        //SphereL2.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);
                        //SphereR.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);
                        //SphereR2.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);

                        SphereL3.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);
                        
                        SphereR3.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);
                        

                        for (int i = 0; i <= 120; i++)
                        {
                            SphereL.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, t);
                            
                            SphereR.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, t);
                            

                            //SphereL3.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.02f);
                            //SphereL4.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.02f);
                            //SphereR3.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.02f);
                            //SphereR4.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.02f);
                            if (i == 40)
                            {
                                t = 0.01f;
                                //HaikeiManager.haikei_flag = 0;
                            }

                            yield return new WaitForSeconds(0.03f);
                        }

                        t = 0.005f;
                        break;

                    default:

                        s = 0;
                        u = 0;
                        break;

                }



                break;
            }

            //yield return new WaitForSeconds(16);
        }

    }
}

