using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMaterialX : MonoBehaviour
{
    public Material[] mat;
    public int flg = 0;
    public int laps = 0;
    private int i = 0;
    
    public static int flag_H = 1;//背景の切り替え方式（2種類：16秒間隔、144秒間隔）
   
    // Start is called before the first frame update
    void Start()
    {    
        IEnumerator coroutine = SetMat();
        StartCoroutine(coroutine);        
    }


    IEnumerator SetMat()
    {
        while (true)
        {
            this.GetComponent<Renderer>().material = mat[i];
            if (laps == 0 & i == 0)
            {
                this.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.99f);
            }
            yield return Touka(flg,laps);
            //Touka(0,0)早朝→昼
            //Touka(1,0)
            //gameObject.GetComponent<SetMaterialX>().enabled = false;
            i++;
            flg++;
            if (i == 2)
            {
                i = 0;
                laps++;
                //flg += 1;
            }
        }       
    }

    public IEnumerator Touka(int flag,int laps)
    {
        GameObject SphereL2 = GameObject.Find("SphereL2");
        GameObject SphereR2 = GameObject.Find("SphereR2");
        Material Noon_Left = Resources.Load("Texture/New_Texture/" + "Noon_Left") as Material;
        Material Noon_Right = Resources.Load("Texture/New_Texture/" + "Noon_Right") as Material;
        Material LaterEvening_Left = Resources.Load("Texture/New_Texture/" + "LaterEvening_Left") as Material;
        Material LaterEvening_Right = Resources.Load("Texture/New_Texture/" + "LaterEvening_Right") as Material;


        if (flag == 0 & laps == 0)//初期条件
        {
            int s = 0;
            int u = 0;

            while (s <= 28 || u <= 248)
            {
                Debug.Log("ok");
                switch (flag_H %2)
                {
                    case 0:
                        for (int i = 0; i < 28; i++)
                        {
                            if (flag_H == 1)//0.5秒ごとにflag_Hの値が1に変化していないか確認。変化していた場合、flag_H=1用のループへ。
                            {
                                break;
                            }
                            s++;
                            yield return new WaitForSeconds(0.5f);
                            Debug.Log("s = " + s);
                            if (s == 28)
                            {
                                Debug.Log("通常変化開始");
                            }
                        }
                        break;

                    case 1:
                        for (int j = 0; j < 248; j++)
                        {
                            u++;
                            if (flag_H == 0)//0.5秒ごとにflag_Hの値を確認する。
                            {
                                break;
                            }
                            if(flag_H %2 == 0 && 220 <= u && 247 >= u)
                            {
                                flag_H++;
                                u = 0;
                                Debug.Log("uuu = " + u);
                                continue;
                            }
                            
                            yield return new WaitForSeconds(0.5f);
                            Debug.Log("u = " + u);
                            
                            if (u == 248)
                            {
                                //Debug.Log("u = " + u);

                                Debug.Log("ナレーション用背景変化開始");
                                flag_H = 0;
                            }
                        }
                        continue;

                    default:
                        break;

                }

                HaikeiManager.haikei_flag = 1;
                yield return new WaitForSeconds(2f);
                s = 0;
                u = 0;
                break;
            }
            
    
            for (int i = 0; i <= 50; i++)
            {
                GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.02f);
                if(i == 25)
                {
                    Manager.delete(1, 0);
                }
                if (i == 35)
                {
                    HaikeiManager.haikei_flag = 0;
                }
                yield return new WaitForSeconds(0.1f);
            }
         
            //gameObject.GetComponent<SetMaterialX>().enabled = false;
            
        }
        else
        {
            int s = 0;
            int u = 0;
            //次に進むかどうか
            while (s <= 28 || u <= 220)
            {
                Debug.Log("ok");
                switch (flag_H)
                {
                    case 0:
                        for (int i = 0; i < 28; i++)
                        {
                            if (flag_H == 1)//0.5秒ごとにflag_Hの値が1に変化していないか確認。変化していた場合、flag_H=1用のループへ。
                            {
                                break;
                            }
                            s++;
                            yield return new WaitForSeconds(0.5f);
                            Debug.Log("s = " + s);
                            if(s == 28)
                            {
                                Debug.Log("通常変化開始");
                            }
                        }
                        break;

                    case 1:
                        for (int j = 0; j < 220; j++)
                        {
                            if (flag_H == 0)//0.5秒ごとにflag_Hの値を確認する。
                            {
                                break;
                            }
                            u++;
                            yield return new WaitForSeconds(0.5f);
                            Debug.Log("u = " + u);
                            
                            if (u == 220)
                            {
                                Debug.Log("u = " + u);
                                
                                Debug.Log("ナレーション用背景変化開始");
                                flag_H++;
                            }
                        }
                        break;

                    default:
                        break;

                }

                HaikeiManager.haikei_flag = 1;
                yield return new WaitForSeconds(2f);
                s = 0;
                u = 0;
                break;
            }

            for (int i = 0; i <= 50; i++)//徐々に不透明にk
            {
                GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.02f);
                if(i == 25)
                {
                    if (flag % 2 == 1)
                    {
                        Manager.delete(2, 0);//昼の透明オブジェクトを消去
                    }
                    else
                    {
                        Manager.delete(4, 1);//夜の透明オブジェクトを消去
                    }
                }
                if (i == 35)//このタイミングでシャワーの描画を許可（haikei_flagを0にする)
                {
                    HaikeiManager.haikei_flag = 0;
                }
                yield return new WaitForSeconds(0.1f);
            }

            if (flag % 2 == 1)
            {
                SphereL2.GetComponent<Renderer>().material = LaterEvening_Left;
                SphereR2.GetComponent<Renderer>().material = LaterEvening_Right;
            }
            else if (flag %2 == 0)
            {
                SphereL2.GetComponent<Renderer>().material = Noon_Left;
                SphereR2.GetComponent<Renderer>().material = Noon_Right;
            }

            //次に進むかどうか
            while (s <= 28 || u <= 220)
            {
                switch (flag_H)
                {
                    case 0:
                        for (int i = 0; i < 28; i++)
                        {
                            if (flag_H == 1)//0.5秒ごとにflag_Hの値が1に変化していないか確認。変化していた場合、flag_H=1用のループへ。
                            {
                                break;
                            }
                            s++;
                            yield return new WaitForSeconds(0.5f);
                            Debug.Log("s = " + s);
                            if(s == 28)
                            {
                                Debug.Log("通常変化開始");
                            }
                        }
                        break;

                    case 1:
                        for (int j = 0; j < 220; j++)
                        {
                            if (flag_H == 0)//0.5秒ごとにflag_Hの値を確認する。
                            {
                                break;
                            }
                            u++;
                            yield return new WaitForSeconds(0.5f);
                            Debug.Log("u = " + u);
                            if(u == 220)
                            {
                                Debug.Log("ナレーション用背景変化開始");
                                flag_H++;
                            }
                        }
                        break;

                    default:
                        break;
                }

                HaikeiManager.haikei_flag = 1;

                yield return new WaitForSeconds(2f);
                s = 0;
                u = 0;
                break;
            }

            for (int i = 0; i <= 50; i++)
            {
                GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.02f);
                if(i == 25)
                {
                    if (flag % 2 == 1)
                    {
                        Manager.delete(3, 1);
                    }
                    else
                    {
                        Manager.delete(1, 1);
                    }
                }
                if(i == 35)//このタイミングでシャワーの描画を許可（haikei_flagを0にする)
                {
                    HaikeiManager.haikei_flag = 0;
                }
                yield return new WaitForSeconds(0.1f);
            }

            //yield return new WaitForSeconds(16);
        }
        
    }
}
