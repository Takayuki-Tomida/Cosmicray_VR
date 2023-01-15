using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private static AudioSource audioSource;
    public int flag = 0;
    public static int narration_flag = 0;
    public static float audio_length = 0f;
    public static float audio_length_flag = 0;//audio_length_flagが奇数ならばオーディオが再生中

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void check_narration_seq()
    {
        while (true)
        {
            //トリガーが引かれたタイミングで以下の状態の時はナレーションの頭出しは行わないようにする
            //シャワー音が流れている時
            //シャワーが描画されている時
            //背景が変化中の時
            if (!audioSource.isPlaying)
            {
                ShowArrow2.arrow_flag = 1;
                ShowerManager.shower_coroutine_flag++;//シャワーコルーチン終了
                break;
            }

            else if (audioSource.isPlaying)
            {
                Debug.Log("ナレーションの再生中です");
            }

            break;
        }
        //yield return new WaitForSeconds(10f);
    }
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.E))//pcでのデバッグ作業時のトリガーはEボタン
        if (OVRInput.Get(OVRInput.Button.One))//Quest2コントローラの場合
        {
            Debug.Log("Triggered");
            check_narration_seq();
        }
    }
}