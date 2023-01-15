using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class show_tips20km : MonoBehaviour//Textに
{
    static int f = 0;
    private Text text;
    private Image image;
    public float red, green, blue;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();//Textコンポーネントを入手
        IEnumerator coroutine = maketransparent();
        StartCoroutine(coroutine);
        f = 1;
    }
    void OnEnable()
    {
        if (f == 1)
        {
            StartCoroutine("maketransparent");
        }

    }
    private IEnumerator maketransparent()
    {
        float alfa;//透過度に関するパラメータであるα値に関する変数
        float i = 0;
        alfa = GetComponent<Text>().color.a;//透過度（α値）の初期値を設定
        alfa = 1.0f;
        //panelの色を取得
        red = GetComponent<Text>().color.r;
        green = GetComponent<Text>().color.g;
        blue = GetComponent<Text>().color.b;

        GetComponent<Text>().color = new Color(red, green, blue, 0);
        for (int j = 0; j <= 80; j++)
        { //以下fading
            i += 0.0125f; //α値増加
            GetComponent<Text>().color = new Color(red, green, blue, i); //color値設定
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(4.0f);//距離情報の表示時間のパラメータ

        for (int j = 0; j <= 200; j++)
        { //以下fading
            alfa -= 0.007f; //α値減少
            GetComponent<Text>().color = new Color(red, green, blue, alfa); //color値設定
            yield return new WaitForSeconds(0.01f);
        }
        GetComponent<Text>().color = new Color(red, green, blue, 0); //alfa値がマイナスになっているので0で上書き
        yield return new WaitForSeconds(3.3f);
        //Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
