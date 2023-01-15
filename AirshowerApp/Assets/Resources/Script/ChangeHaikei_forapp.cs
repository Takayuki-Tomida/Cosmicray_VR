using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���̃X�N���v�g��SphereL�ɃA�^�b�`����
//Earlymorning(255)��(255��1)��Evening(1)��(1��255)��(255��1)��Earlymorning(1)��(1��255)���ŏ��ɖ߂�

public class ChangeHaikei_forapp : MonoBehaviour
{
    public Material[] mat;
    public int flg = 0;
    public int laps = 0;
    private int i = 0;

    public static int flag_H = 1;//�w�i�̐؂�ւ������i2��ށF16�b�Ԋu�A144�b�Ԋu�j
    public static int flag_S = 0;//1�ɂȂ�����ʏ탋�[�v�Ɉړ�

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
                

                SphereL.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.99f);//EarlyMorning�͏�����Ԃœ����x1�Ȃ̂ōŏ��̂�
                
                SphereR.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.99f);//EarlyMorning�͏�����Ԃœ����x1�Ȃ̂ōŏ��̂�
                
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
        if (flag == 0 & laps == 0)//��������
        {
            int s = 0;
            int u = 0;

            while (s <= 140 || u <= 1420)
            {
                Debug.Log("�C���g���̃��[�v");
                switch (flag_H % 2)
                {
                    case 0:
                        for (int i = 0; i < 140; i++)
                        {
                            if (flag_H % 2 == 1)//flag_H=1�ɕω����Ă����ꍇ�A�`���[�g���A���p��for����
                            {
                                goto case 1;
                                //break;
                            }
                            s++;
                            yield return new WaitForSeconds(0.1f);
                            Debug.Log("s = " + s);
                            if (s == 140)
                            {
                                Debug.Log("�ʏ�ω��J�n");
                                goto case 2;
                            }
                        }
                        break;

                    case 1:
                        for (int j = 0; j < 1420; j++)
                        {
                            u++;

                            //u��216�𒴂���ƃL�[�{�[�hE���́i�i���[�V�����ĊJ�g���K�[�j���󂯕t����悤�ɂȂ�
                            //�g���K�[���͎��̊e�p�����[�^�[�̕ω�
                            //1) �V�����[���`�悳��Ă��Ȃ��^�C�~���O�Ńg���K�[���������ꍇ
                            //flag_H++ ���@�����Ƀ`���[�g���A���p�̔w�i�؂�ւ�(124s)�ɕύX����B
                            //2) �V�����[���`�悳��Ă���^�C�~���O�Ńg���K�[���������ꍇ
                            //audio_length_flag++ ���@�V�����[�����̎c��̍Đ����Ԃ��v�Z���A���̎��Ԃ��o�߂�����flag_H = 2
                            //�܂莞�Ԃ�������x�����邽�߉���if���ɂ͈���������Ȃ�

                            if (flag_H % 2 == 0 && 1080 <= u && 1420 >= u)//flag_H����Ńi���[�V�����������I��肩�w�i���؂�ւ���Ă��Ȃ��ꍇ
                            {
                                flag_H++;
                                u = 0;
                                Debug.Log("�ŏ��̃C���g������Ƀ{�^����������܂���");
                                Debug.Log("flag_H = " + flag_H);
                                break;
                            }

                            yield return new WaitForSeconds(0.1f);
                            Debug.Log("u = " + u);

                            if (u == 1420)
                            {
                                Debug.Log("�i���[�V�����p�w�i�ω��J�n");
                                flag_H++;//�ʏ탋�[�v�ɓ���
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

        else//�i���[�V�����I����̓���
        {

            int s = 0;
            int u = 0;
            //���ɐi�ނ��ǂ���
            while (s <= 140 || u <= 1420)
            {
                Debug.Log("2��ڂ̃��[�v");
                switch (flag_H % 2)
                {
                    case 0:
                        for (int i = 0; i < 140; i++)
                        {
                            if (flag_H % 2 == 1)//flag_H=1�ɕω����Ă����ꍇ�A�`���[�g���A���p��for����
                            {
                                goto case 1;
                                //break;
                            }
                            s++;
                            yield return new WaitForSeconds(0.1f);
                            Debug.Log("s = " + s);
                            if (s == 140)
                            {
                                Debug.Log("�ʏ�ω��J�n");
                                goto case 2;
                            }
                        }
                        break;

                    case 1:
                        for (int j = 0; j < 1420; j++)
                        {
                            u++;

                            //u��216�𒴂���ƃL�[�{�[�hE���́i�i���[�V�����ĊJ�g���K�[�j���󂯕t����悤�ɂȂ�
                            //�g���K�[���͎��̊e�p�����[�^�[�̕ω�
                            //1) �V�����[���`�悳��Ă��Ȃ��^�C�~���O�Ńg���K�[���������ꍇ
                            //flag_H++ ���@�����Ƀ`���[�g���A���p�̔w�i�؂�ւ�(124s)�ɕύX����B
                            //2) �V�����[���`�悳��Ă���^�C�~���O�Ńg���K�[���������ꍇ
                            //audio_length_flag++ ���@�V�����[�����̎c��̍Đ����Ԃ��v�Z���A���̎��Ԃ��o�߂�����flag_H = 2
                            //�܂莞�Ԃ�������x�����邽�߉���if���ɂ͈���������Ȃ�

                            if (flag_H % 2 == 0 && 1080 <= u && 1420 >= u)//flag_H����Ńi���[�V�����������I��肩�w�i���؂�ւ���Ă��Ȃ��ꍇ
                            {
                                flag_H++;
                                u = 0;
                                Debug.Log("�ŏ��̃C���g������Ƀ{�^����������܂���");

                                break;
                            }

                            yield return new WaitForSeconds(0.1f);
                            Debug.Log("u = " + u);

                            if (u == 1420)
                            {
                                Debug.Log("�i���[�V�����p�w�i�ω��J�n");
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
                            for (int i = 0; i <= 120; i++)//���X�ɕs������k
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
                            for (int i = 0; i <= 270; i++)//���X�ɕs������k
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

            //���ɐi�ނ��ǂ���
            while (s <= 140 || u <= 1420)
            {
                Debug.Log("3��ڂ̃��[�v");
                switch (flag_H % 2)
                {
                    case 0:
                        for (int i = 0; i < 140; i++)
                        {
                            if (flag_H % 2 == 1)//flag_H=1�ɕω����Ă����ꍇ�A�`���[�g���A���p��for����
                            {
                                goto case 1;
                                //break;
                            }
                            s++;
                            yield return new WaitForSeconds(0.1f);
                            Debug.Log("s = " + s);
                            if (s == 140)
                            {
                                Debug.Log("�ʏ�ω��J�n");
                                goto case 2;
                            }
                        }
                        break;

                    case 1:
                        for (int j = 0; j < 1420; j++)
                        {
                            u++;

                            //u��216�𒴂���ƃL�[�{�[�hE���́i�i���[�V�����ĊJ�g���K�[�j���󂯕t����悤�ɂȂ�
                            //�g���K�[���͎��̊e�p�����[�^�[�̕ω�
                            //1) �V�����[���`�悳��Ă��Ȃ��^�C�~���O�Ńg���K�[���������ꍇ
                            //flag_H++ ���@�����Ƀ`���[�g���A���p�̔w�i�؂�ւ�(124s)�ɕύX����B
                            //2) �V�����[���`�悳��Ă���^�C�~���O�Ńg���K�[���������ꍇ
                            //audio_length_flag++ ���@�V�����[�����̎c��̍Đ����Ԃ��v�Z���A���̎��Ԃ��o�߂�����flag_H = 2
                            //�܂莞�Ԃ�������x�����邽�߉���if���ɂ͈���������Ȃ�

                            if (flag_H % 2 == 0 && 1080 <= u && 1420 >= u)//flag_H����Ńi���[�V�����������I��肩�w�i���؂�ւ���Ă��Ȃ��ꍇ
                            {
                                flag_H++;
                                u = 0;
                                Debug.Log("�ŏ��̃C���g������Ƀ{�^����������܂���");

                                break;
                            }

                            yield return new WaitForSeconds(0.1f);
                            Debug.Log("u = " + u);

                            if (u == 1420)
                            {
                                Debug.Log("�i���[�V�����p�w�i�ω��J�n");
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

