using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private static AudioSource audioSource;
    public int flag = 0;
    public static int narration_flag = 0;
    public static float audio_length = 0f;
    public static float audio_length_flag = 0;//audio_length_flag����Ȃ�΃I�[�f�B�I���Đ���

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void check_narration_seq()
    {
        while (true)
        {
            if (!audioSource.isPlaying)
            {
                ShowArrow2.arrow_flag = 1;
                ChangeHaikei.flag_H++;
                ShowerManager.shower_coroutine_flag++;//�V�����[�R���[�`���I��
                break;
            }

            else if (audioSource.isPlaying)
            {
                Debug.Log("�i���[�V�����̍Đ����ł�");
                break;
            }
        }
        //yield return new WaitForSeconds(10f);
    }
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.E))//�g���K�[���Ђ��ꂽ��
        if (OVRInput.GetDown(OVRInput.Button.One))//Quest2�R���g���[���̏ꍇ
        {
            Debug.Log("Triggered");
            check_narration_seq();
        }
    }
}