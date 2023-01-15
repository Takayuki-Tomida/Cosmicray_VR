using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���̃X�N���v�g��SphereL�ɃA�^�b�`����
//Earlymorning(255)��(255��1)��Evening(1)��(1��255)��(255��1)��Earlymorning(1)��(1��255)���ŏ��ɖ߂�

public class changetest : MonoBehaviour
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
        GameObject SphereL2 = GameObject.Find("SphereL2");
        GameObject SphereL3 = GameObject.Find("SphereL3");
        GameObject SphereL4 = GameObject.Find("SphereL4");
        GameObject SphereR = GameObject.Find("SphereR");
        GameObject SphereR2 = GameObject.Find("SphereR2");
        GameObject SphereR3 = GameObject.Find("SphereR3");
        GameObject SphereR4 = GameObject.Find("SphereR4");

        Material EarlyMorning_Left = Resources.Load("Texture/New_Texture/" + "EarlyMorning_Left") as Material;
        Material EarlyMorning_Left2 = Resources.Load("Texture/New_Texture/" + "EarlyMorning_Left2") as Material;
        Material Noon_Left = Resources.Load("Texture/New_Texture/" + "Noon_Left") as Material;
        Material Noon_Left2 = Resources.Load("Texture/New_Texture/" + "Noon_Left2") as Material;
        Material Evening_Left = Resources.Load("Texture/New_Texture/" + "Evening_Left") as Material;
        Material Evening_Left2 = Resources.Load("Texture/New_Texture/" + "Evening_Left2") as Material;
        Material LaterEvening_Left = Resources.Load("Texture/New_Texture/" + "LaterEvening_Left") as Material;
        Material LaterEvening_Left2 = Resources.Load("Texture/New_Texture/" + "LaterEvening_Left2") as Material;
        Material EarlyMorning_Right = Resources.Load("Texture/New_Texture/" + "EarlyMorning_Right") as Material;
        Material EarlyMorning_Right2 = Resources.Load("Texture/New_Texture/" + "EarlyMorning_Right2") as Material;
        Material Noon_Right = Resources.Load("Texture/New_Texture/" + "Noon_Right") as Material;
        Material Noon_Right2 = Resources.Load("Texture/New_Texture/" + "Noon_Right2") as Material;
        Material Evening_Right = Resources.Load("Texture/New_Texture/" + "Evening_Right") as Material;
        Material Evening_Right2 = Resources.Load("Texture/New_Texture/" + "Evening_Right2") as Material;
        Material LaterEvening_Right = Resources.Load("Texture/New_Texture/" + "LaterEvening_Right") as Material;
        Material LaterEvening_Right2 = Resources.Load("Texture/New_Texture/" + "LaterEvening_Right2") as Material;

        while (true)
        {
            if(cnt == 0)
            {
                SphereL.GetComponent<Renderer>().material = EarlyMorning_Left;
                SphereL2.GetComponent<Renderer>().material = EarlyMorning_Left2;
                SphereR.GetComponent<Renderer>().material = EarlyMorning_Right;
                SphereR2.GetComponent<Renderer>().material = EarlyMorning_Right2;
                SphereL3.GetComponent<Renderer>().material = Noon_Left;
                SphereL4.GetComponent<Renderer>().material = Noon_Left2;
                SphereR3.GetComponent<Renderer>().material = Noon_Right;
                SphereR4.GetComponent<Renderer>().material = Noon_Right2;

                SphereL.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.99f);//EarlyMorning�͏�����Ԃœ����x1�Ȃ̂ōŏ��̂�
                SphereL2.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.99f);//EarlyMorning�͏�����Ԃœ����x1�Ȃ̂ōŏ��̂�
                SphereR.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.99f);//EarlyMorning�͏�����Ԃœ����x1�Ȃ̂ōŏ��̂�
                SphereR2.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.99f);//EarlyMorning�͏�����Ԃœ����x1�Ȃ̂ōŏ��̂�
            }

            //yield return new WaitForSeconds(6f);

            //for (int i = 0; i <= 50; i++)
            //{
            //    SphereL.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.02f);
            //    SphereL2.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.02f);
            //    SphereR.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.02f);
            //    SphereR2.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.02f);

            //    SphereL3.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.02f);
            //    SphereL4.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.02f);
            //    SphereR3.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.02f);
            //    SphereR4.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.02f);
            //    yield return new WaitForSeconds(0.1f);
            //}

            //SphereL.GetComponent<Renderer>().material = Evening_Left;
            //SphereL2.GetComponent<Renderer>().material = Evening_Left2;
            //SphereR.GetComponent<Renderer>().material = Evening_Right;
            //SphereR2.GetComponent<Renderer>().material = Evening_Right2;

            //yield return new WaitForSeconds(6f);

            ////SphereL.GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0.02f);
            ////SphereL2.GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0.02f);

            //for (int i = 0; i <= 50; i++)
            //{
            //    SphereL.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.02f);
            //    SphereL2.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.02f);
            //    SphereR.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.02f);
            //    SphereR2.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.02f);

            //    SphereL3.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.02f);
            //    SphereL4.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.02f);
            //    SphereR3.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.02f);
            //    SphereR4.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.02f);
            //    yield return new WaitForSeconds(0.1f);
            //}

            //yield return new WaitForSeconds(6f);

            //SphereL3.GetComponent<Renderer>().material = LaterEvening_Left;
            //SphereL4.GetComponent<Renderer>().material = LaterEvening_Left2;
            //SphereR3.GetComponent<Renderer>().material = LaterEvening_Right;
            //SphereR4.GetComponent<Renderer>().material = LaterEvening_Right2;

            //for (int i = 0; i <= 50; i++)
            //{
            //    SphereL.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.02f);
            //    SphereL2.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.02f);
            //    SphereR.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.02f);
            //    SphereR2.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.02f);

            //    SphereL3.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.02f);
            //    SphereL4.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.02f);
            //    SphereR3.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.02f);
            //    SphereR4.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.02f);
            //    yield return new WaitForSeconds(0.1f);
            //}

            //yield return new WaitForSeconds(6f);

            yield return Touka(flg, laps, SphereL, SphereL2, SphereL3, SphereL4, SphereR, SphereR2, SphereR3, SphereR4, EarlyMorning_Left, EarlyMorning_Left2, Noon_Left, Noon_Left2, Evening_Left, Evening_Left2, LaterEvening_Left, LaterEvening_Left2, EarlyMorning_Right, EarlyMorning_Right2, Noon_Right, Noon_Right2, Evening_Right, Evening_Right2, LaterEvening_Right, LaterEvening_Right2);
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

    public IEnumerator Touka(int flag, int laps, GameObject SphereL, GameObject SphereL2, GameObject SphereL3, GameObject SphereL4, GameObject SphereR, GameObject SphereR2, GameObject SphereR3, GameObject SphereR4, Material EarlyMorning_Left, Material EarlyMorning_Left2, Material Noon_Left, Material Noon_Left2, Material Evening_Left, Material Evening_Left2, Material LaterEvening_Left, Material LaterEvening_Left2, Material EarlyMorning_Right, Material EarlyMorning_Right2, Material Noon_Right, Material Noon_Right2, Material Evening_Right, Material Evening_Right2, Material LaterEvening_Right, Material LaterEvening_Right2)
    {
        //GameObject SphereL3 = GameObject.Find("SphereL3");
        //Material Noon_Left = Resources.Load("Texture/New_Texture/" + "Noon_Left") as Material;
        //Material LaterEvening_Left = Resources.Load("Texture/New_Texture/" + "LaterEvening_Left") as Material;

        if (flag == 0 & laps == 0)//��������
        {
            int s = 0;
            int u = 0;

            while (s <= 140 || u <= 1280)
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
                        for (int j = 0; j < 1280; j++)
                        {
                            u++;

                            //u��216�𒴂���ƃL�[�{�[�hE���́i�i���[�V�����ĊJ�g���K�[�j���󂯕t����悤�ɂȂ�
                            //�g���K�[���͎��̊e�p�����[�^�[�̕ω�
                            //1) �V�����[���`�悳��Ă��Ȃ��^�C�~���O�Ńg���K�[���������ꍇ
                            //flag_H++ ���@�����Ƀ`���[�g���A���p�̔w�i�؂�ւ�(124s)�ɕύX����B
                            //2) �V�����[���`�悳��Ă���^�C�~���O�Ńg���K�[���������ꍇ
                            //audio_length_flag++ ���@�V�����[�����̎c��̍Đ����Ԃ��v�Z���A���̎��Ԃ��o�߂�����flag_H = 2
                            //�܂莞�Ԃ�������x�����邽�߉���if���ɂ͈���������Ȃ�

                            if (flag_H % 2 == 0 && 1080 <= u && 1280 >= u)//flag_H����Ńi���[�V�����������I��肩�w�i���؂�ւ���Ă��Ȃ��ꍇ
                            {
                                flag_H++;
                                u = 0;
                                Debug.Log("�ŏ��̃C���g������Ƀ{�^����������܂���");
                                Debug.Log("flag_H = " + flag_H);
                                break;
                            }

                            yield return new WaitForSeconds(0.1f);
                            Debug.Log("u = " + u);

                            if (u == 1)
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

                        HaikeiManager.haikei_flag = 1;
                        yield return new WaitForSeconds(2f);
                        if (cnt == 0)
                        {
                            for (int i = 0; i <= 100; i++)//�������i1�x�������s�j
                            {
                                SphereL.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.01f);
                                SphereL2.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.01f);
                                SphereR.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.01f);
                                SphereR2.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.01f);

                                SphereL3.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.01f);
                                SphereL4.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.01f);
                                SphereR3.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.01f);
                                SphereR4.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.01f);

                                if (i == 50)
                                {
                                    Manager.delete(1, 0);
                                }
                                if (i == 70)
                                {
                                    HaikeiManager.haikei_flag = 0;
                                }
                                yield return new WaitForSeconds(0.05f);
                            }
                        }

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

        else
        {
            int s = 0;
            int u = 0;
            //���ɐi�ނ��ǂ���
            while (s <= 140 || u <= 1280)
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
                        for (int j = 0; j < 1280; j++)
                        {
                            u++;

                            //u��216�𒴂���ƃL�[�{�[�hE���́i�i���[�V�����ĊJ�g���K�[�j���󂯕t����悤�ɂȂ�
                            //�g���K�[���͎��̊e�p�����[�^�[�̕ω�
                            //1) �V�����[���`�悳��Ă��Ȃ��^�C�~���O�Ńg���K�[���������ꍇ
                            //flag_H++ ���@�����Ƀ`���[�g���A���p�̔w�i�؂�ւ�(124s)�ɕύX����B
                            //2) �V�����[���`�悳��Ă���^�C�~���O�Ńg���K�[���������ꍇ
                            //audio_length_flag++ ���@�V�����[�����̎c��̍Đ����Ԃ��v�Z���A���̎��Ԃ��o�߂�����flag_H = 2
                            //�܂莞�Ԃ�������x�����邽�߉���if���ɂ͈���������Ȃ�

                            if (flag_H % 2 == 0 && 1080 <= u && 1280 >= u)//flag_H����Ńi���[�V�����������I��肩�w�i���؂�ւ���Ă��Ȃ��ꍇ
                            {
                                flag_H++;
                                u = 0;
                                Debug.Log("�ŏ��̃C���g������Ƀ{�^����������܂���");

                                break;
                            }

                            yield return new WaitForSeconds(0.1f);
                            Debug.Log("u = " + u);

                            if (u == 1280)
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

                        HaikeiManager.haikei_flag = 1;

                        yield return new WaitForSeconds(2f);

                        if(cnt %2 == 1)
                        {
                            SphereL.GetComponent<Renderer>().material = Evening_Left;
                            SphereL2.GetComponent<Renderer>().material = Evening_Left2;
                            SphereR.GetComponent<Renderer>().material = Evening_Right;
                            SphereR2.GetComponent<Renderer>().material = Evening_Right2;
                        }
                        else
                        {
                            SphereL.GetComponent<Renderer>().material = EarlyMorning_Left;
                            SphereL2.GetComponent<Renderer>().material = EarlyMorning_Left2;
                            SphereR.GetComponent<Renderer>().material = EarlyMorning_Right;
                            SphereR2.GetComponent<Renderer>().material = EarlyMorning_Right2;
                        }

                        SphereL.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 0);
                        SphereL2.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 0);
                        SphereR.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 0);
                        SphereR2.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 0);

                        SphereL3.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
                        SphereL4.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
                        SphereR3.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
                        SphereR4.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
                        Debug.Log("Called");

                        for (int i = 0; i <= 100; i++)//�����[���遨��
                        {
                            SphereL.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.01f);
                            SphereL2.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.01f);
                            SphereR.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.01f);
                            SphereR2.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.01f);

                            SphereL3.GetComponent<Renderer>().material.color -= new Color(0f, 0f, 0f, 0.01f);
                            SphereL4.GetComponent<Renderer>().material.color -= new Color(0f, 0f, 0f, 0.01f);
                            SphereR3.GetComponent<Renderer>().material.color -= new Color(0f, 0f, 0f, 0.01f);
                            SphereR4.GetComponent<Renderer>().material.color -= new Color(0f, 0f, 0f, 0.01f);
                            if (i == 50)
                            {
                                if (flag % 2 == 1)
                                {
                                    Manager.delete(2, 0);//���̓����I�u�W�F�N�g������
                                }
                                else
                                {
                                    Manager.delete(4, 1);//��̓����I�u�W�F�N�g������
                                }
                            }
                            if (i == 70)//���̃^�C�~���O�ŃV�����[�̕`������ihaikei_flag��0�ɂ���)
                            {
                                HaikeiManager.haikei_flag = 0;
                            }
                            yield return new WaitForSeconds(0.05f);
                        }
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
            while (s <= 140 || u <= 1280)
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
                        for (int j = 0; j < 1280; j++)
                        {
                            u++;

                            //u��216�𒴂���ƃL�[�{�[�hE���́i�i���[�V�����ĊJ�g���K�[�j���󂯕t����悤�ɂȂ�
                            //�g���K�[���͎��̊e�p�����[�^�[�̕ω�
                            //1) �V�����[���`�悳��Ă��Ȃ��^�C�~���O�Ńg���K�[���������ꍇ
                            //flag_H++ ���@�����Ƀ`���[�g���A���p�̔w�i�؂�ւ�(124s)�ɕύX����B
                            //2) �V�����[���`�悳��Ă���^�C�~���O�Ńg���K�[���������ꍇ
                            //audio_length_flag++ ���@�V�����[�����̎c��̍Đ����Ԃ��v�Z���A���̎��Ԃ��o�߂�����flag_H = 2
                            //�܂莞�Ԃ�������x�����邽�߉���if���ɂ͈���������Ȃ�

                            if (flag_H % 2 == 0 && 1080 <= u && 1280 >= u)//flag_H����Ńi���[�V�����������I��肩�w�i���؂�ւ���Ă��Ȃ��ꍇ
                            {
                                flag_H++;
                                u = 0;
                                Debug.Log("�ŏ��̃C���g������Ƀ{�^����������܂���");

                                break;
                            }

                            yield return new WaitForSeconds(0.1f);
                            Debug.Log("u = " + u);

                            if (u == 1280)
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

                        HaikeiManager.haikei_flag = 1;
                        yield return new WaitForSeconds(2f);

                        if (cnt % 2 == 1)
                        {
                            SphereL3.GetComponent<Renderer>().material = LaterEvening_Left;
                            SphereL4.GetComponent<Renderer>().material = LaterEvening_Left2;
                            SphereR3.GetComponent<Renderer>().material = LaterEvening_Right;
                            SphereR4.GetComponent<Renderer>().material = LaterEvening_Right2;
                        }
                        else
                        {
                            SphereL3.GetComponent<Renderer>().material = Noon_Left;
                            SphereL4.GetComponent<Renderer>().material = Noon_Left2;
                            SphereR3.GetComponent<Renderer>().material = Noon_Right;
                            SphereR4.GetComponent<Renderer>().material = Noon_Right2;
                        }

                        SphereL.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
                        SphereL2.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
                        SphereR.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
                        SphereR2.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);

                        SphereL3.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 0);
                        SphereL4.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 0);
                        SphereR3.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 0);
                        SphereR4.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 0);

                        for (int i = 0; i <= 100; i++)//�[���違������
                        {
                            SphereL.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.01f);
                            SphereL2.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.01f);
                            SphereR.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.01f);
                            SphereR2.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.01f);

                            SphereL3.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.01f);
                            SphereL4.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.01f);
                            SphereR3.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.01f);
                            SphereR4.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.01f);
                            if (i == 50)
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
                            if (i == 70)//���̃^�C�~���O�ŃV�����[�̕`������ihaikei_flag��0�ɂ���)
                            {
                                HaikeiManager.haikei_flag = 0;
                            }
                            yield return new WaitForSeconds(0.05f);
                        }


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

