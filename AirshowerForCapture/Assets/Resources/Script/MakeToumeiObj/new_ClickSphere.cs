using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//①クリックした位置に球を配置する
//②クリックした座標を記録し、distanceを掛けて任意の距離の座標情報を得る
public class new_ClickSphere : MonoBehaviour
{
    public GameObject prefab;
    public GameObject[] vertex_num = new GameObject[200];//生成する球の数の上限を決定
    private Vector3 mousePosition;
    int i = 0;
    float theta = 0f;
    float phi = 0f;
    float fixed_x, fixed_y, fixed_z;
    public int distance = 70;//山の場合70、建物の場合40
    public static List<Vector3> vertex_list = new List<Vector3>();
    Vector3 v = new Vector3(0f, 0f, 0f);


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePosition = Input.mousePosition;
            mousePosition.z = 50.0f;//適当な値で設定（この値は重要でない）
            //vertex_list = Camera.main.ScreenToWorldPoint(mousePosition);

            //球を生成する----------------------------------------------------
            //Debug.Log("クリックされた座標＝ " + Camera.main.ScreenToWorldPoint(mousePosition));
            vertex_num[i] = Instantiate(prefab, Camera.main.ScreenToWorldPoint(mousePosition), Quaternion.identity);
            i++;
            //----------------------------------------------------------------

            v = Camera.main.ScreenToWorldPoint(mousePosition);

            new_triangle2 tr2 = GetComponent<new_triangle2>();
            //球の座標がカメラからある一定の値の距離になるよう調整
            //(x,y,z)→(θ,φ)
            theta = Mathf.Acos(v.z / Mathf.Sqrt(Mathf.Pow(v.x, 2f) + Mathf.Pow(v.y, 2f) + Mathf.Pow(v.z, 2f)));
            phi = Mathf.Sign(v.y) * Mathf.Acos(v.x / Mathf.Sqrt(Mathf.Pow(v.x, 2f) + Mathf.Pow(v.y, 2f)));
            fixed_x = distance * Mathf.Sin(theta) * Mathf.Cos(phi);
            fixed_y = distance * Mathf.Sin(theta) * Mathf.Sin(phi);
            fixed_z = distance * Mathf.Cos(theta);

            v.x = fixed_x;
            v.y = fixed_y;
            v.z = fixed_z;

            tr2.addvertice(v);

            //test here ------------------------------------------------------
            vertex_list.Add(v);

            if (vertex_list.Count % 2 == 0 && vertex_list.Count != 0)
            {
                //GetComponent<DynamicCreateMesh>().generate_toumeiobj();
                //DynamicCreateMesh.generate_toumeiobj();
                Debug.Log($"頂点数は{vertex_list.Count}個です");
            }

            //----------------------------------------------------------------
        }

        if (Input.GetMouseButtonDown(1))//球を削除
        {
            i--;
            Destroy(vertex_num[i]);
            new_triangle2 tr2 = GetComponent<new_triangle2>();
            tr2.delvertice();
        }

        if (Input.GetKeyDown(KeyCode.P))//配列に格納された頂点データを見る
        {
            foreach (Vector3 name in vertex_list)
            {
                Debug.Log(name);
            }
        }
    }
}
