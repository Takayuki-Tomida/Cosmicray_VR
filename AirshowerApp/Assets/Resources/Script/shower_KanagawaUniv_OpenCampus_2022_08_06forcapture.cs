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
            Debug.Log("�R���[�`���͐V���ɃX�^�[�g���܂���");
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

            yield return new WaitForSeconds(13.0f);//���w���p�i���[�V�����̃V�����[�̃C���g���_�N�V�����܂ő҂�(���w���p�i���[�V�������j

            EffectIntro10km.ShowerAdd(68.64f, 84.85f, 49.87f, 0, 0, -17, "Introshower_10km", 96, 115.2f);//��
            //Effect2.ShowerAdd(55.33f, 33.28f, 16.2f, 0, 70, -19, "quest2_showerL_introduction", 137, 137);//��i5km�̊�j
            yield return new WaitForSeconds(18.6f);

            EffectIntro20km.ShowerAdd(-33.06f, 53.67f, 101.75f, 0, 0, -19, "Introshower_20km", 60, 72);//��

            yield return new WaitForSeconds(18f);

            EffectIntro5km.ShowerAdd(53.62f, 103.92f, 26.93f, 0, 0, 10, "Introshower_5km", 120, 140);//��i5km�̊�j

            yield return new WaitForSeconds(13.9f);//���w���p�i���[�V�������I���܂ő҂�

            //���w���i���[�V�����p
            //10km��
            Effect10km.ShowerAdd(68.64f, 84.85f, 49.87f, 0, 0, -17, "10kmshower", 96, 115.2f);//��
            yield return new WaitForSeconds(5.3f);//10km��`20km��̊Ԃ̎���

            //20km��
            Effect20km.ShowerAdd(96.64f, 53.67f, 45.91f, 0, 0, 0, "20kmshower", 60, 72);//��
            yield return new WaitForSeconds(5.1f);//5s�ҋ@

            //40km��
            Effect40km.ShowerAdd(105.7f, 29.1f, 47.78f, 0, 0, -20, "40kmshower", 30, 40);//��
            yield return new WaitForSeconds(5f);//5s�ҋ@

            //80km��
            Effect80km.ShowerAdd(119f, 14.8f, 0f, 0, 0, 30, "80kmshower", 12, 20.8f);//�쐼

            //�`���[�g���A���I����̍ŏ��̃V�����[�̍~���Ă���^�C�~���O
            yield return new WaitForSeconds(33f);//5s�ҋ@

            //�w�i�؂�ւ��̃^�C�~���O�̕ύX��Y��Ȃ�
            yield return new WaitForSeconds(1f);//5s�ҋ@
            while (true)
            {
                //if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                //{
                //    break;//�V�����[�R���[�`���I��
                //}



                UnityEngine.Random.InitState(System.DateTime.Now.Millisecond);//�V�[�h�l�����ݎ�����
                new_x = UnityEngine.Random.Range(0, 7);

                if (new_x == temp_x)//���ɍ~��V�����[���O�̃V�����[�Ɠ��������������ꍇ�A�ʂ̂Ƃ���ɍ~�点��
                {
                    new_x++;
                    if (new_x == 7)
                    {
                        new_x = 0;
                    }
                }

                temp_x = new_x;
                Debug.Log("������������");
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

                switch (new_x)//���p��rand
                {
                    case 0://��
                        Debug.Log("��ɍ~��܂�");
                        UnityEngine.Random.InitState(System.DateTime.Now.Millisecond);//�V�[�h�l�����ݎ�����
                        new_y = UnityEngine.Random.Range(0, 8);
                        switch (new_y)
                        {
                            case 0:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(53.62f, 103.92f, 26.93f, 0, 0, 10, "5kmshower", 120, 140);//��
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//�g���K�[�������ꂽ��Ăяo��
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 1:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(32.97f, 103.92f, 50.132f, 0, 0, -17, "5kmshower", 120, 140);//��
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//�g���K�[�������ꂽ��Ăяo��
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 2:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(68.64f, 84.85f, 49.87f, 0, 0, -17, "10kmshower", 96, 115.2f);//��
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 3:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(80.69f, 84.85f, 26.218f, 0, 0, 22, "10kmshower", 96, 115.2f);//��
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 4:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(86.56f, 53.67f, 62.89f, 0, 0, -20, "20kmshower", 60, 72);//��
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 5:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(96.64f, 53.67f, 45.91f, 0, 0, 0, "20kmshower", 60, 72);//��
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 6:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(105.7f, 29.1f, 47.78f, 0, 0, 20, "40kmshower", 30, 40);//��
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 7:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(105.7f, 29.1f, 47.78f, 0, 0, -20, "40kmshower", 30, 40);//��
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            default:
                                Debug.Log("failed");
                                break;
                        }
                        break;

                    case 1://��
                        Debug.Log("���ɍ~��܂�");
                        UnityEngine.Random.InitState(System.DateTime.Now.Millisecond);//�V�[�h�l�����ݎ�����
                        new_y = UnityEngine.Random.Range(0, 8);
                        switch (new_y)
                        {
                            case 0:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(-12.13f, 103.92f, 58.76f, 0, 0, 8, "5kmshower", 120, 140);//��
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 1:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(-39.88f, 103.92f, 44.82f, 0, 0, -18, "5kmshower", 120, 140);//��
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 2:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(-8.87f, 84.85f, 84.38f, 0, 0, 20, "10kmshower", 96, 115.2f);//��
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 3:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(-8.87f, 84.85f, 84.38f, 0, 0, -4, "10kmshower", 96, 115.2f);//��
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 4:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(-33.06f, 53.67f, 101.75f, 0, 0, 9, "20kmshower", 60, 72);//��
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 5:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(-33.06f, 53.67f, 101.75f, 0, 0, -19, "20kmshower", 60, 72);//��
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 6:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(-30.65f, 29.1f, 111.87f, 0, 0, 4, "40kmshower", 30, 40);//��
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 7:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(-8.236f, 29.1f, 115.699f, 0, 0, -17, "40kmshower", 30, 40);//��
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            default:
                                Debug.Log("failed");
                                break;
                        }
                        break;

                    case 2://��
                        Debug.Log("���ɍ~��܂�");
                        UnityEngine.Random.InitState(System.DateTime.Now.Millisecond);//�V�[�h�l�����ݎ�����
                        new_y = UnityEngine.Random.Range(0, 10);
                        switch (new_y)
                        {
                            case 0:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(44.35f, 103.92f, -40.4f, 0, 0, -13, "5kmshower", 120, 140);//��
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 1:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(-12.81f, 103.92f, -58.608f, 0, 0, 13, "5kmshower", 120, 140);//��
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 2:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(-13.27f, 84.85f, -83.8f, 0, 0, 4, "10kmshower", 96, 115.2f);//��
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 3:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(7.17f, 84.85f, -84.54f, 0, 0, 20, "10kmshower", 96, 115.2f);//��
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 4:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(3.87f, 53.67f, -107f, 0, 0, -9, "20kmshower", 60, 72);//��
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 5:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(3.87f, 53.67f, -107f, 0, 0, 23, "20kmshower", 60, 72);//��
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 6:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(30.656f, 29.1f, -111.87f, 0, 0, 24, "40kmshower", 30, 40);//��
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 7:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(60.931f, 29.1f, -98.70f, 0, 0, -14, "40kmshower", 30, 40);//��
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 8:
                                if (flag_y == 80)
                                {
                                    continue;
                                }
                                Effect80km.ShowerAdd(47.13f, 14.8f, -109.26f, 0, 0, -10, "80kmshower", 12, 20.8f);//��
                                flag_y = 80;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 9:
                                if (flag_y == 80)
                                {
                                    continue;
                                }
                                Effect80km.ShowerAdd(47.13f, 14.8f, -109.26f, 0, 0, 20, "80kmshower", 12, 20.8f);//��
                                flag_y = 80;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            default:
                                Debug.Log("failed");
                                break;
                        }
                        break;

                    case 3://�쐼
                        Debug.Log("�쐼�ɍ~��܂�");
                        UnityEngine.Random.InitState(System.DateTime.Now.Millisecond);//�V�[�h�l�����ݎ�����
                        new_y = UnityEngine.Random.Range(0, 10);
                        switch (new_y)
                        {
                            case 0:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(56.75f, 103.92f, 19.49f, 0, 0, -17, "5kmshower", 120, 140);//�쐼
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 1:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(57.367f, 103.92f, -17.59f, 0, 0, 14, "5kmshower", 120, 140);//�쐼
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 2:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(84.85f, 84.85f, 0f, 0, 0, -7, "10kmshower", 96, 115.2f);//�쐼
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 3:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(83.219f, 84.85f, 16.55f, 0, 0, -16, "10kmshower", 96, 115.2f);//�쐼
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 4:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(107f, 53.67f, 0f, 0, 0, 3, "20kmshower", 60, 72);//�쐼
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 5:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(103.354f, 53.67f, -27.693f, 0, 0, 23, "20kmshower", 60, 72);//�쐼
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 6:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(116f, 29.1f, 0f, 0, 0, -10, "40kmshower", 30, 40);//�쐼
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 7:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(116f, 29.1f, 0f, 0, 0, 18, "40kmshower", 30, 40);//�쐼
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 8:
                                if (flag_y == 80)
                                {
                                    continue;
                                }
                                Effect80km.ShowerAdd(119f, 14.8f, 0f, 0, 0, 30, "80kmshower", 12, 20.8f);//�쐼
                                flag_y = 80;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 9:
                                if (flag_y == 80)
                                {
                                    continue;
                                }
                                Effect80km.ShowerAdd(119f, 14.8f, 0f, 0, 0, -20, "80kmshower", 12, 20.8f);//�쐼
                                flag_y = 80;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            default:
                                Debug.Log("failed");
                                break;
                        }
                        break;

                    case 4://�k��
                        Debug.Log("�k���ɍ~��܂�");
                        UnityEngine.Random.InitState(System.DateTime.Now.Millisecond);//�V�[�h�l�����ݎ�����
                        new_y = UnityEngine.Random.Range(0, 10);
                        switch (new_y)
                        {
                            case 0:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(-20.35f, 103.92f, -56.43f, 0, 0, -18, "5kmshower", 120, 140);//�k��
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 1:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(-20.35f, 103.92f, -56.43f, 0, 0, 0, "5kmshower", 120, 140);//�k��
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 2:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(-68.64f, 84.85f, -49.87f, 0, 0, 24, "10kmshower", 96, 115.2f);//�k��
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 3:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(-54.71f, 84.85f, -64.847f, 0, 0, 0, "10kmshower", 96, 115.2f);//�k��
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 4:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(-75.65f, 53.67f, -75.65f, 0, 0, 29, "20kmshower", 60, 72);//�k��
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 5:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(-51.27f, 53.67f, -93.898f, 0, 0, -3, "20kmshower", 60, 72);//�k��
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 6:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(-57.43f, 29.1f, -100.78f, 0, 0, -24, "40kmshower", 30, 40);//�k��
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 7:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(-57.43f, 29.1f, -100.78f, 0, 0, 24, "40kmshower", 30, 40);//�k��
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 8:
                                if (flag_y == 80)
                                {
                                    continue;
                                }
                                Effect80km.ShowerAdd(-81.66f, 14.8f, -86.557f, 0, 0, 30, "80kmshower", 12, 20.8f);//�k��
                                flag_y = 80;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 9:
                                if (flag_y == 80)
                                {
                                    continue;
                                }
                                Effect80km.ShowerAdd(-72.484f, 14.8f, -94.374f, 0, 0, -20, "80kmshower", 12, 20.8f);//�k��
                                flag_y = 80;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            default:
                                Debug.Log("failed");
                                break;
                        }
                        break;


                    case 5://�쓌
                        Debug.Log("�쓌�ɍ~��܂�");
                        UnityEngine.Random.InitState(System.DateTime.Now.Millisecond);//�V�[�h�l�����ݎ�����
                        new_y = UnityEngine.Random.Range(0, 8);
                        switch (new_y)
                        {
                            case 0:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(32.97f, 103.92f, 50.13f, 0, 0, 20, "5kmshower", 120, 140);//�쓌
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 1:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(32.97f, 103.92f, 50.13f, 0, 0, 6, "5kmshower", 120, 140);//�쓌
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 2:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(34.51f, 84.85f, 77.51f, 0, 0, 7, "10kmshower", 96, 115.2f);//�쓌
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 3:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(34.51f, 84.85f, 77.51f, 0, 0, -17, "10kmshower", 96, 115.2f);//�쓌
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 4:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(33.06f, 53.67f, 101.75f, 0, 0, 0, "20kmshower", 60, 72);//�쓌
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 5:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(62.88f, 53.67f, 86.55f, 0, 0, 20, "20kmshower", 60, 72);//�쓌
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 6:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(57.43f, 29.1f, 100.78f, 0, 0, -20, "40kmshower", 30, 40);//�쓌
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 7:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(78.415f, 29.1f, 85.473f, 0, 0, 13, "40kmshower", 30, 40);//�쓌
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            default:
                                Debug.Log("failed");
                                break;
                        }
                        break;

                    case 6://�k��
                        Debug.Log("�k���ɍ~��܂�");
                        UnityEngine.Random.InitState(System.DateTime.Now.Millisecond);//�V�[�h�l�����ݎ�����
                        new_y = UnityEngine.Random.Range(0, 8);
                        switch (new_y)
                        {
                            case 0:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(-44.35f, 103.92f, 40.4f, 0, 0, 8, "5kmshower", 120, 140);//�k��
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 1:
                                if (flag_y == 5)
                                {
                                    continue;
                                }
                                Effect5km.ShowerAdd(-58.61f, 103.92f, 12.81f, 0, 0, -18, "5kmshower", 120, 140);//�k��
                                flag_y = 5;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 2:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(-66.75f, 84.85f, 52.37f, 0, 0, 14, "10kmshower", 96, 115.2f);//�k��
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 3:
                                if (flag_y == 10)
                                {
                                    continue;
                                }
                                Effect10km.ShowerAdd(-80.636f, 84.85f, 26.38f, 0, 0, -18, "10kmshower", 96, 115.2f);//�k��
                                flag_y = 10;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 4:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(-86.56f, 53.67f, 62.89f, 0, 0, 29, "20kmshower", 60, 72);//�k��
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 5:
                                if (flag_y == 20)
                                {
                                    continue;
                                }
                                Effect20km.ShowerAdd(-100.77f, 53.67f, 35.955f, 0, 0, -29, "20kmshower", 60, 72);//�k��
                                flag_y = 20;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 6:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(-100.78f, 29.1f, 57.42f, 0, 0, 14, "40kmshower", 30, 40);//�k��
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
                                    }
                                }
                                break;

                            case 7:
                                if (flag_y == 40)
                                {
                                    continue;
                                }
                                Effect40km.ShowerAdd(-104.463f, 29.1f, 50.408f, 0, 0, -12, "40kmshower", 30, 40);//�k��
                                flag_y = 40;
                                for (int i = 0; i < 50; i++)
                                {
                                    yield return new WaitForSeconds(0.1f);//7s�ҋ@
                                    if (ShowerManager.shower_coroutine_flag % 2 == 1)//
                                    {
                                        flag++;
                                        break;//�V�����[�R���[�`���I��
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

                if (ShowerManager.shower_coroutine_flag % 2 == 1)//�ʏ탋�[�v(7�b�Ԋu�ŃV�����[�~���Ă���j���甲����
                {
                    break;
                }

            }
            continue;
        }
    }

}