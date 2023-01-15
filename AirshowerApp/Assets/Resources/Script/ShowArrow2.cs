using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowArrow2 : MonoBehaviour
{
    public static int arrow_flag = 0;//繰り返し使用する際に使用

    private Material material_low, material_middle, material_up;//80km先のシャワー用マテリアル
    private Material low, middle, up;//誘導用マテリアル1
    private Material low2, middle2, up2;//誘導用マテリアル2
    private Material low3, middle3, up3;//誘導用マテリアル3
    private Material low4, middle4, up4;//誘導用マテリアル4
    private Material low5, middle5, up5;//誘導用マテリアル5
    private Material low6, middle6, up6;//誘導用マテリアル6
    private Material low7, middle7, up7;//誘導用マテリアル7
    private Material low8, middle8, up8;//誘導用マテリアル8
    private Material low9, middle9, up9;//誘導用マテリアル9
    private Material low10, middle10, up10;//誘導用マテリアル10
    private Material low11, middle11, up11;//誘導用マテリアル11

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("coroutine80km");
        StartCoroutine("coroutineR");
        StartCoroutine("coroutineKyoriJyouhou");
    }

    void Update()
    {
        if (arrow_flag == 1)
        {
            StartCoroutine("coroutine80km");
            StartCoroutine("coroutineR");
            StartCoroutine("coroutineKyoriJyouhou");
            Debug.Log("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            arrow_flag = 0;
        }
    }

    private IEnumerator coroutineKyoriJyouhou()//距離情報を表示する
    {
        yield return new WaitForSeconds(1f);
        GameObject five = GameObject.Find("5km先情報");
        GameObject ten = GameObject.Find("10km先情報");
        GameObject twenty = GameObject.Find("20km先情報");
        GameObject fourty = GameObject.Find("40km先情報");
        GameObject eighty = GameObject.Find("80km先情報");


        yield return new WaitForSeconds(64.1f);

        foreach (Transform item in five.transform)
        {
            item.gameObject.SetActive(true);
        }
        yield return new WaitForSeconds(10.2f);//これより大きければ何でもよい
        //foreach (Transform item in five.transform)
        //{
        //    item.gameObject.SetActive(false);
        //}
        yield return new WaitForSeconds(1.3f);

        foreach (Transform item in five.transform)
        {
            item.gameObject.SetActive(false);
        }
        foreach (Transform item in ten.transform)
        {
            item.gameObject.SetActive(true);
        }

        yield return new WaitForSeconds(7.1f);//これより大きければ何でもよい

        foreach (Transform item in ten.transform)
        {
            item.gameObject.SetActive(false);
        }
        //yield return new WaitForSeconds(1f);


        foreach (Transform item in twenty.transform)
        {
            item.gameObject.SetActive(true);
        }

        yield return new WaitForSeconds(7.1f);//これより大きければ何でもよい

        foreach (Transform item in twenty.transform)
        {
            item.gameObject.SetActive(false);
        }
        //yield return new WaitForSeconds(1f);

        foreach (Transform item in fourty.transform)
        {
            item.gameObject.SetActive(true);
        }
        yield return new WaitForSeconds(7.2f);//これより大きければ何でもよい
        foreach (Transform item in fourty.transform)
        {
            item.gameObject.SetActive(false);
        }
        //yield return new WaitForSeconds(1f);


        foreach (Transform item in eighty.transform)
        {
            item.gameObject.SetActive(true);
        }
        yield return new WaitForSeconds(8.8f);//これより大きければ何でもよい
        foreach (Transform item in eighty.transform)
        {
            item.gameObject.SetActive(false);
        }

    }

    private IEnumerator coroutineR()
    {
        yield return new WaitForSeconds(2.2f);
        //Debug.Log("ArrowCoroutine has started");
        GameObject ShowYuudouArrow = GameObject.Find("ShowYuudouArrow");
        GameObject ShowYuudouArrow2 = GameObject.Find("ShowYuudouArrow2");
        GameObject ShowYuudouArrow3 = GameObject.Find("ShowYuudouArrow3");

        //矢印_左へ誘導1
        //-----------------------------------------------------------------------------
        GameObject cd = ShowYuudouArrow.transform.Find("矢印_左へ誘導1").gameObject;
        //矢印の下部分
        GameObject gcd_low = cd.transform.Find("下").gameObject;
        GameObject ggcd_low = gcd_low.transform.Find("Cube_Down").gameObject;
        low = ggcd_low.GetComponent<Renderer>().material;
        //矢印の中部分
        GameObject gcd_middle = cd.transform.Find("真ん中").gameObject;
        GameObject ggcd_middle = gcd_middle.transform.Find("Cube_Middle").gameObject;
        middle = ggcd_middle.GetComponent<Renderer>().material;
        //矢印の上部分
        GameObject gcd_up = cd.transform.Find("上").gameObject;
        GameObject ggcd_up = gcd_up.transform.Find("Cube_Up").gameObject;
        up = ggcd_up.GetComponent<Renderer>().material;
        //-----------------------------------------------------------------------------

        //矢印_左へ誘導2
        //-----------------------------------------------------------------------------
        GameObject cd2 = ShowYuudouArrow.transform.Find("矢印_左へ誘導2").gameObject;
        //矢印の下部分
        GameObject gcd_low2 = cd2.transform.Find("下").gameObject;
        GameObject ggcd_low2 = gcd_low2.transform.Find("Cube_Down").gameObject;
        low2 = ggcd_low2.GetComponent<Renderer>().material;
        //矢印の中部分
        GameObject gcd_middle2 = cd2.transform.Find("真ん中").gameObject;
        GameObject ggcd_middle2 = gcd_middle2.transform.Find("Cube_Middle").gameObject;
        middle2 = ggcd_middle2.GetComponent<Renderer>().material;
        //矢印の上部分
        GameObject gcd_up2 = cd2.transform.Find("上").gameObject;
        GameObject ggcd_up2 = gcd_up2.transform.Find("Cube_Up").gameObject;
        up2 = ggcd_up2.GetComponent<Renderer>().material;
        //-----------------------------------------------------------------------------

        //矢印_左へ誘導3
        //-----------------------------------------------------------------------------
        GameObject cd3 = ShowYuudouArrow3.transform.Find("矢印_左へ誘導3").gameObject;
        //矢印の下部分
        GameObject gcd_low3 = cd3.transform.Find("下").gameObject;
        GameObject ggcd_low3 = gcd_low3.transform.Find("Cube_Down").gameObject;
        low3 = ggcd_low3.GetComponent<Renderer>().material;
        //矢印の中部分
        GameObject gcd_middle3 = cd3.transform.Find("真ん中").gameObject;
        GameObject ggcd_middle3 = gcd_middle3.transform.Find("Cube_Middle").gameObject;
        middle3 = ggcd_middle3.GetComponent<Renderer>().material;
        //矢印の上部分
        GameObject gcd_up3 = cd3.transform.Find("上").gameObject;
        GameObject ggcd_up3 = gcd_up3.transform.Find("Cube_Up").gameObject;
        up3 = ggcd_up3.GetComponent<Renderer>().material;
        //-----------------------------------------------------------------------------

        //矢印_左へ誘導4
        //-----------------------------------------------------------------------------
        GameObject cd4 = ShowYuudouArrow.transform.Find("矢印_左へ誘導4").gameObject;
        //矢印の下部分
        GameObject gcd_low4 = cd4.transform.Find("下").gameObject;
        GameObject ggcd_low4 = gcd_low4.transform.Find("Cube_Down").gameObject;
        low4 = ggcd_low4.GetComponent<Renderer>().material;
        //矢印の中部分
        GameObject gcd_middle4 = cd4.transform.Find("真ん中").gameObject;
        GameObject ggcd_middle4 = gcd_middle4.transform.Find("Cube_Middle").gameObject;
        middle4 = ggcd_middle4.GetComponent<Renderer>().material;
        //矢印の上部分
        GameObject gcd_up4 = cd4.transform.Find("上").gameObject;
        GameObject ggcd_up4 = gcd_up4.transform.Find("Cube_Up").gameObject;
        up4 = ggcd_up4.GetComponent<Renderer>().material;
        //-----------------------------------------------------------------------------

        //矢印_左へ誘導5
        //-----------------------------------------------------------------------------
        GameObject cd5 = ShowYuudouArrow3.transform.Find("矢印_左へ誘導5").gameObject;
        //矢印の下部分
        GameObject gcd_low5 = cd5.transform.Find("下").gameObject;
        GameObject ggcd_low5 = gcd_low5.transform.Find("Cube_Down").gameObject;
        low5 = ggcd_low5.GetComponent<Renderer>().material;
        //矢印の中部分
        GameObject gcd_middle5 = cd5.transform.Find("真ん中").gameObject;
        GameObject ggcd_middle5 = gcd_middle5.transform.Find("Cube_Middle").gameObject;
        middle5 = ggcd_middle5.GetComponent<Renderer>().material;
        //矢印の上部分
        GameObject gcd_up5 = cd5.transform.Find("上").gameObject;
        GameObject ggcd_up5 = gcd_up5.transform.Find("Cube_Up").gameObject;
        up5 = ggcd_up5.GetComponent<Renderer>().material;
        //-----------------------------------------------------------------------------

        //矢印_左へ誘導6
        ////-----------------------------------------------------------------------------
        GameObject cd6 = ShowYuudouArrow3.transform.Find("矢印_左へ誘導6").gameObject;
        //矢印の下部分
        GameObject gcd_low6 = cd6.transform.Find("下").gameObject;
        GameObject ggcd_low6 = gcd_low6.transform.Find("Cube_Down").gameObject;
        low6 = ggcd_low6.GetComponent<Renderer>().material;
        //矢印の中部分
        GameObject gcd_middle6 = cd6.transform.Find("真ん中").gameObject;
        GameObject ggcd_middle6 = gcd_middle6.transform.Find("Cube_Middle").gameObject;
        middle6 = ggcd_middle6.GetComponent<Renderer>().material;
        //矢印の上部分
        GameObject gcd_up6 = cd6.transform.Find("上").gameObject;
        GameObject ggcd_up6 = gcd_up6.transform.Find("Cube_Up").gameObject;
        up6 = ggcd_up6.GetComponent<Renderer>().material;
        //-----------------------------------------------------------------------------

        //矢印_右へ誘導7
        //-----------------------------------------------------------------------------
        GameObject cd7 = ShowYuudouArrow2.transform.Find("矢印_右へ誘導7").gameObject;
        //矢印の下部分
        GameObject gcd_low7 = cd7.transform.Find("下").gameObject;
        GameObject ggcd_low7 = gcd_low7.transform.Find("Cube_Down").gameObject;
        low7 = ggcd_low7.GetComponent<Renderer>().material;
        //矢印の中部分
        GameObject gcd_middle7 = cd7.transform.Find("真ん中").gameObject;
        GameObject ggcd_middle7 = gcd_middle7.transform.Find("Cube_Middle").gameObject;
        middle7 = ggcd_middle7.GetComponent<Renderer>().material;
        //矢印の上部分
        GameObject gcd_up7 = cd7.transform.Find("上").gameObject;
        GameObject ggcd_up7 = gcd_up7.transform.Find("Cube_Up").gameObject;
        up7 = ggcd_up7.GetComponent<Renderer>().material;
        //-----------------------------------------------------------------------------

        //矢印_右へ誘導8
        //-----------------------------------------------------------------------------
        GameObject cd8 = ShowYuudouArrow2.transform.Find("矢印_右へ誘導8").gameObject;
        //矢印の下部分
        GameObject gcd_low8 = cd8.transform.Find("下").gameObject;
        GameObject ggcd_low8 = gcd_low8.transform.Find("Cube_Down").gameObject;
        low8 = ggcd_low8.GetComponent<Renderer>().material;
        //矢印の中部分
        GameObject gcd_middle8 = cd8.transform.Find("真ん中").gameObject;
        GameObject ggcd_middle8 = gcd_middle8.transform.Find("Cube_Middle").gameObject;
        middle8 = ggcd_middle8.GetComponent<Renderer>().material;
        //矢印の上部分
        GameObject gcd_up8 = cd8.transform.Find("上").gameObject;
        GameObject ggcd_up8 = gcd_up8.transform.Find("Cube_Up").gameObject;
        up8 = ggcd_up8.GetComponent<Renderer>().material;
        //-----------------------------------------------------------------------------

        //矢印_右へ誘導9
        //-----------------------------------------------------------------------------
        GameObject cd9 = ShowYuudouArrow2.transform.Find("矢印_右へ誘導9").gameObject;
        //矢印の下部分
        GameObject gcd_low9 = cd9.transform.Find("下").gameObject;
        GameObject ggcd_low9 = gcd_low9.transform.Find("Cube_Down").gameObject;
        low9 = ggcd_low9.GetComponent<Renderer>().material;
        //矢印の中部分
        GameObject gcd_middle9 = cd9.transform.Find("真ん中").gameObject;
        GameObject ggcd_middle9 = gcd_middle9.transform.Find("Cube_Middle").gameObject;
        middle9 = ggcd_middle9.GetComponent<Renderer>().material;
        //矢印の上部分
        GameObject gcd_up9 = cd9.transform.Find("上").gameObject;
        GameObject ggcd_up9 = gcd_up9.transform.Find("Cube_Up").gameObject;
        up9 = ggcd_up9.GetComponent<Renderer>().material;
        //-----------------------------------------------------------------------------

        ////矢印_右へ誘導10
        ////-----------------------------------------------------------------------------
        GameObject cd10 = ShowYuudouArrow2.transform.Find("矢印_右へ誘導10").gameObject;
        //矢印の下部分
        GameObject gcd_low10 = cd10.transform.Find("下").gameObject;
        GameObject ggcd_low10 = gcd_low10.transform.Find("Cube_Down").gameObject;
        low10 = ggcd_low10.GetComponent<Renderer>().material;
        //矢印の中部分
        GameObject gcd_middle10 = cd10.transform.Find("真ん中").gameObject;
        GameObject ggcd_middle10 = gcd_middle10.transform.Find("Cube_Middle").gameObject;
        middle10 = ggcd_middle10.GetComponent<Renderer>().material;
        //矢印の上部分
        GameObject gcd_up10 = cd10.transform.Find("上").gameObject;
        GameObject ggcd_up10 = gcd_up10.transform.Find("Cube_Up").gameObject;
        up10 = ggcd_up10.GetComponent<Renderer>().material;
        //-----------------------------------------------------------------------------

        ////矢印_右へ誘導11
        ////-----------------------------------------------------------------------------
        GameObject cd11 = ShowYuudouArrow2.transform.Find("矢印_右へ誘導11").gameObject;
        //矢印の下部分
        GameObject gcd_low11 = cd11.transform.Find("下").gameObject;
        GameObject ggcd_low11 = gcd_low11.transform.Find("Cube_Down").gameObject;
        low11 = ggcd_low11.GetComponent<Renderer>().material;
        //矢印の中部分
        GameObject gcd_middle11 = cd11.transform.Find("真ん中").gameObject;
        GameObject ggcd_middle11 = gcd_middle11.transform.Find("Cube_Middle").gameObject;
        middle11 = ggcd_middle11.GetComponent<Renderer>().material;
        //矢印の上部分
        GameObject gcd_up11 = cd11.transform.Find("上").gameObject;
        GameObject ggcd_up11 = gcd_up11.transform.Find("Cube_Up").gameObject;
        up11 = ggcd_up11.GetComponent<Renderer>().material;
        //-----------------------------------------------------------------------------

        yield return new WaitForSeconds(24.6f);//最初の誘導矢印が出るまで待機

        foreach (Transform item in ShowYuudouArrow.transform)
        {
            item.gameObject.SetActive(true);
        }

        float alfa = 0.0f;
        float alfa_holo = 0.0f;
        for (int j = 0; j <= 100; j++)
        { //以下fading
            //Color Cd = new Color(1.0f, 1.0f, 1.0f, alfa);
            low.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa));
            middle.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa));
            up.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa));
            low2.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa));
            middle2.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa));
            up2.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa));
            low4.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa));
            middle4.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa));
            up4.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa));

            low.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa_holo));
            middle.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa_holo));
            up.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa_holo));
            low2.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa_holo));
            middle2.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa_holo));
            up2.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa_holo));
            low4.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa_holo));
            middle4.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa_holo));
            up4.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa_holo));

            alfa += 0.01f;
            alfa_holo += 0.005f;
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(1.5f);

        alfa = 1.0f;
        alfa_holo = 0.5f;

        for (int j = 0; j <= 100; j++)
        { //以下fading
            alfa -= 0.01f; //α値減少値
            alfa_holo -= 0.005f;
            low.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa));
            middle.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa));
            up.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa));
            low2.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa));
            middle2.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa));
            up2.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa));
            low4.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa));
            middle4.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa));
            up4.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa));

            low.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa_holo));
            middle.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa_holo));
            up.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa_holo));
            low2.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa_holo));
            middle2.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa_holo));
            up2.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa_holo));
            low4.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa_holo));
            middle4.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa_holo));
            up4.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa_holo));
            yield return new WaitForSeconds(0.01f);
        }

        foreach (Transform item in ShowYuudouArrow.transform)
        {
            item.gameObject.SetActive(false);
        }
        yield return new WaitForSeconds(12.1f);

        foreach (Transform item2 in ShowYuudouArrow2.transform)
        {
            item2.gameObject.SetActive(true);
        }

        float alfa2 = 0.0f;
        float alfa2_holo = 0.0f;
        for (int j = 0; j <= 100; j++)
        { //以下fading
            //Color Cd = new Color(1.0f, 1.0f, 1.0f, alfa);
            low7.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            middle7.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            up7.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            low8.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            middle8.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            up8.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            low9.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            middle9.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            up9.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            low10.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            middle10.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            up10.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            low11.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            middle11.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            up11.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));

            low7.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            middle7.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            up7.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            low8.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            middle8.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            up8.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            low9.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            middle9.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            up9.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            low10.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            middle10.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            up10.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            low11.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            middle11.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            up11.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));

            alfa2 += 0.01f;
            alfa2_holo += 0.005f;
            yield return new WaitForSeconds(0.01f);
        }

        yield return new WaitForSeconds(2f);

        alfa2 = 1.0f;
        alfa2_holo = 0.5f;
        for (int j = 0; j <= 100; j++)
        { //以下fading
            //Color Cd = new Color(1.0f, 1.0f, 1.0f, alfa);
            low7.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            middle7.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            up7.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            low8.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            middle8.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            up8.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            low9.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            middle9.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            up9.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            low10.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            middle10.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            up10.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            low11.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            middle11.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));
            up11.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa2));

            low7.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            middle7.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            up7.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            low8.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            middle8.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            up8.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            low9.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            middle9.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            up9.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            low10.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            middle10.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            up10.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            low11.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            middle11.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));
            up11.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa2_holo));

            alfa2 -= 0.01f;
            alfa2_holo -= 0.005f;
            yield return new WaitForSeconds(0.01f);
        }
        foreach (Transform item2 in ShowYuudouArrow2.transform)
        {
            item2.gameObject.SetActive(false);
        }

        yield return new WaitForSeconds(12.3f);

        foreach (Transform item3 in ShowYuudouArrow3.transform)
        {
            item3.gameObject.SetActive(true);
        }

        float alfa3 = 0.0f;
        float alfa3_holo = 0.0f;
        for (int j = 0; j <= 100; j++)
        { //以下fading
            //Color Cd = new Color(1.0f, 1.0f, 1.0f, alfa);
            low3.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa3));
            middle3.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa3));
            up3.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa3));
            low5.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa3));
            middle5.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa3));
            up5.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa3));
            low6.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa3));
            middle6.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa3));
            up6.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa3));

            low3.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa3_holo));
            middle3.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa3_holo));
            up3.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa3_holo));
            low5.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa3_holo));
            middle5.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa3_holo));
            up5.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa3_holo));
            low6.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa3_holo));
            middle6.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa3_holo));
            up6.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa3_holo));


            alfa3 += 0.01f;
            alfa3_holo += 0.005f;
            yield return new WaitForSeconds(0.01f);
        }

        yield return new WaitForSeconds(1.0f);

        alfa3 = 1.0f;
        alfa3_holo = 0.5f;
        for (int j = 0; j <= 100; j++)
        { //以下fading
            //Color Cd = new Color(1.0f, 1.0f, 1.0f, alfa);
            low3.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa3));
            middle3.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa3));
            up3.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa3));
            low5.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa3));
            middle5.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa3));
            up5.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa3));
            low6.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa3));
            middle6.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa3));
            up6.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa3));

            low3.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa3_holo));
            middle3.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa3_holo));
            up3.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa3_holo));
            low5.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa3_holo));
            middle5.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa3_holo));
            up5.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa3_holo));
            low6.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa3_holo));
            middle6.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa3_holo));
            up6.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa3_holo));

            alfa3 -= 0.01f;
            alfa3_holo -= 0.005f;
            yield return new WaitForSeconds(0.01f);
        }
        foreach (Transform item3 in ShowYuudouArrow3.transform)
        {
            item3.gameObject.SetActive(false);
        }
    }


    private IEnumerator coroutine80km()
    {
        yield return new WaitForSeconds(2.3f);
        yield return new WaitForSeconds(95.7f);
        GameObject Show80kmArrow = GameObject.Find("Show80kmArrow");

        GameObject cd = Show80kmArrow.transform.Find("矢印_80km").gameObject;
        //矢印の下部分
        GameObject gcd_low = cd.transform.Find("下").gameObject;
        GameObject ggcd_low = gcd_low.transform.Find("Cube_Down").gameObject;
        material_low = ggcd_low.GetComponent<Renderer>().material;
        //矢印の中部分
        GameObject gcd_middle = cd.transform.Find("真ん中").gameObject;
        GameObject ggcd_middle = gcd_middle.transform.Find("Cube_Middle").gameObject;
        material_middle = ggcd_middle.GetComponent<Renderer>().material;
        //矢印の上部分
        GameObject gcd_up = cd.transform.Find("上").gameObject;
        GameObject ggcd_up = gcd_up.transform.Find("Cube_Up").gameObject;
        material_up = ggcd_up.GetComponent<Renderer>().material;


        foreach (Transform item in Show80kmArrow.transform)
        {
            item.gameObject.SetActive(true);
        }

        float alfa3 = 0.0f;
        float alfa3_holo = 0.0f;
        for (int j = 0; j <= 100; j++)
        { //以下fading
            alfa3 += 0.01f; //α値減少値
            alfa3_holo += 0.005f;
            material_low.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa3));
            material_middle.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa3));
            material_up.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa3));

            material_low.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa3_holo));
            material_middle.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa3_holo));
            material_up.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa3_holo));
            yield return new WaitForSeconds(0.01f);
        }
        //yield return new WaitForSeconds(0.5f);


        //GameObject cd = Show80kmArrow.transform.FindChild("矢印").gameObject;
        //矢印の下部分
        //GameObject gcd_low = cd.transform.FindChild("下").gameObject;
        //GameObject ggcd_low = gcd_low.transform.FindChild("Cube_Down").gameObject;
        //material_low = ggcd_low.GetComponent<Renderer>().material;
        //矢印の中部分
        //GameObject gcd_middle = cd.transform.FindChild("真ん中").gameObject;
        //GameObject ggcd_middle = gcd_middle.transform.FindChild("Cube_Middle").gameObject;
        //material_middle = ggcd_middle.GetComponent<Renderer>().material;
        //矢印の上部分
        //GameObject gcd_up = cd.transform.FindChild("上").gameObject;
        //GameObject ggcd_up = gcd_up.transform.FindChild("Cube_Up").gameObject;
        //material_up = ggcd_up.GetComponent<Renderer>().material;

        alfa3 = 1.0f;
        alfa3_holo = 0.5f;
        for (int j = 0; j <= 100; j++)
        { //以下fading
            alfa3 -= 0.01f; //α値減少値
            alfa3_holo -= 0.005f;
            material_low.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa3));
            material_middle.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa3));
            material_up.SetColor("_Color", new Color(0.353f, 1f, 1f, alfa3));

            material_low.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa3_holo));
            material_middle.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa3_holo));
            material_up.SetColor("_HoloColor", new Color(0.353f, 1f, 1f, alfa3_holo));
            yield return new WaitForSeconds(0.01f);
        }

        foreach (Transform item in Show80kmArrow.transform)
        {
            item.gameObject.SetActive(false);
        }
    }
}