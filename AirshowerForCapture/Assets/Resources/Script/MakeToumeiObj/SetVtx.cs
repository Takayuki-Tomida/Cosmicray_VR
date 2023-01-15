using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVtx : MonoBehaviour
{
    // Start is called before the first frame update
    public float[] front_upper_right;
    public float[] front_lower_right;
    public float[] front_lower_left;
    public float[] front_upper_left;
    public float[] back_upper_right;
    public float[] back_lower_right;
    public float[] back_lower_left;
    public float[] back_upper_left;

    void OnEnable()
    {

        Mesh myMesh = GetComponent<MeshFilter>().mesh;
        List<Vector3> myVertices = new List<Vector3>();
        myMesh.GetVertices(myVertices);

        
        //指定した頂点だけ移動させる
        //プリミティブのCubeは1点を3平面で共有しているため
        //3つのverticesの位置を変更する

        //右下奥
        myVertices[0] = myVertices[13] = myVertices[23] = new Vector3(back_lower_right[0], back_lower_right[1], back_lower_right[2]);
        //左下奥
        myVertices[1] = myVertices[14] = myVertices[16] = new Vector3(back_lower_left[0], back_lower_left[1], back_lower_left[2]);
        //右上奥
        myVertices[2] = myVertices[8] = myVertices[22] = new Vector3(back_upper_right[0], back_upper_right[1], back_upper_right[2]);
        //左上奥
        myVertices[3] = myVertices[9] = myVertices[17] = new Vector3(back_upper_left[0], back_upper_left[1], back_upper_left[2]);
        //右上前
        myVertices[4] = myVertices[10] = myVertices[21] = new Vector3(front_upper_right[0], front_upper_right[1], front_upper_right[2]);
        //左上前
        myVertices[5] = myVertices[11] = myVertices[18] = new Vector3(front_upper_left[0], front_upper_left[1], front_upper_left[2]);
        //右下前
        myVertices[6] = myVertices[12] = myVertices[20] = new Vector3(front_lower_right[0], front_lower_right[1], front_lower_right[2]) ;
        //左下前
        myVertices[7] = myVertices[15] = myVertices[19] = new Vector3(front_lower_left[0], front_lower_left[1], front_lower_left[2]);

        myMesh.SetVertices(myVertices);

    }

    void OnDisable()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
