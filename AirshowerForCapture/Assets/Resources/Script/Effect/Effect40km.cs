using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Effect40km : MonoBehaviour
//フィールド（メンバ変数）の定義ここから↓

{   //クラス名　変数名;　でインスタンスを格納する変数を定義
    //publicで宣言しInspectorで外部設定可能にする
    public Sprite[] sprites;//インスタンスを格納するための変数の宣言
    public float speed;//float型のクラス変数speedの宣言
    public static AudioClip se;//AudioClipクラスのインスタンスを格納する変数seの宣言
    public static AudioSource audiosource;
    private Image image;//Imageクラスのインスタンスを格納する変数imageの宣言
    public float red, green, blue; //float型のクラス変数red,green,blueの宣言
    public float time_A = -10.0f;
    public int flag = 0;

    //メンバ変数の定義ここまで↑

    //メソッドの定義ここから↓
    public static void ShowerAdd(float x, float y, float z, float a, float b, float c, string name, float d, float e)
    {
        GameObject prefab = Resources.Load("Prefabs/Prefab_Realshower/pivotfixedshowers/" + name) as GameObject; //""内に参照フォルダ、ResourceはResourceフォルダ以下のみ参照
        Vector3 pos = new Vector3(x, y, z);//座標(x,y,z) Vector3クラスのインスタンス変数posを定義
        Vector3 rotate = new Vector3(a, b, c);//回転rotate(x軸回転、y軸回転、z軸回転) Vector3クラスのインスタンス変数rotateを定義
        Vector2 size = new Vector2(d, e);//d=width、e=heightVector2クラスのインスタンス変数sizeを定義

        GameObject canvas = GameObject.Find("Canvas");//Hierarchy内のCanvasという名前のゲームオブジェクトを探す

        //Instantiate(生成するオブジェクト,生成する位置,回転）でオブジェクトを生成
        //この時点ではプレハブのスプライト
        GameObject g = Instantiate(prefab, pos, Quaternion.identity) as GameObject;//prefabのインスタンスを生成する。Quaternion.idintity:回転はそのまま
        g.transform.SetParent(canvas.transform, false);
        g.transform.position = pos; //位置座標設定

        g.transform.LookAt(new Vector3(0, 29.1f, 0));//y軸に対して平行になるように一度向きを決める

        g.transform.Rotate(rotate); //回転
        g.GetComponent<RectTransform>().sizeDelta = size;//width,heightを適用
    }



    void Start()
    {
        GameObject canvas = GameObject.Find("Canvas");
        canvas.transform.Rotate(0f, -70f, 0f);
        image = GetComponent<Image>();//Imageコンポーネントを入手
        image.sprite = sprites[0];//エアシャワーの写真の先端からスタート
        //GetComponent<AudioSource>().PlayOneShot(se);//エアシャワーの音の再生スタート
        audiosource = GetComponent<AudioSource>();
        audiosource.Play();
        //ここからコルーチンの実行
        IEnumerator coroutine = updateImg();//
        StartCoroutine(coroutine);//コルーチン：フレームをまたいで処理を中断、再開せせることのできる仕組み
        //ここまでコルーチンの実行
        //Effect欄、Audio Sorceの両方に音源を設定
    }

    private IEnumerator updateImg()
    {
        ShowerManager.shower_flag = 1;
        /*int index = 0; //while文を回すためのフラグ用変数
        while (index < sprites.Length - 1) //sprites.Lengthは写真の枚数
        {
            current += Time.deltaTime * speed; //１フレームごとのスピードを変える
            index = (int)(current) % sprites.Length;
            //if (index > sprites.Length - 1) index = sprites.Length - 1;
            image.sprite = sprites[index];
            yield return new WaitForSeconds(0.01f);
        }*/

        float alfa;//透過度に関するパラメータであるα値に関する変数
        alfa = GetComponent<Image>().color.a;//透過度（α値）の初期値を設定
                                             //sprites.Length:gif画像の枚数
                                             //panelの色を取得

        for (double i = 0; i < sprites.Length - 1; i += speed * 0.1)
        { //gifアニメーション用
            image.sprite = sprites[(int)(i)];
            yield return new WaitForSeconds(0.01f);//シャワースピードをここで変える
        }
        yield return new WaitForSeconds(1f);
        //panelの色を取得
        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;
        for (int j = 0; j <= 50; j++)
        { //以下fading
            alfa -= 0.02f; //α値減少値
            GetComponent<Image>().color = new Color(red, green, blue, alfa); //color値設定
            yield return new WaitForSeconds(0.02f);
        }
        //yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
        ShowerManager.shower_flag = 0;
    }
    //メソッドの定義ここまで↑

}