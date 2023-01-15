using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triangle2 : MonoBehaviour
{
    public List<Vector3> vertices = new List<Vector3>{new Vector3(0,-1000000,0)};
    int index = 1;
    public List<int> triangles = new List<int> {0};
    public int newdistance = 77;//山の透明オブジェクトの距離調整
    
    // Start is called before the first frame update
    void Start()
    {
        ClickSphere CS = GetComponent<ClickSphere>();
        if (vertices.Count != 1)
        {

            for (int i = 0; i < vertices.Count; i++)
            {
                //Debug.Log(vertices[i]);
                vertices[i] = vertices[i] / (float)CS.distance;
                vertices[i] = vertices[i] * (float)newdistance;
            }

            //Debug.Log(vertices[1]/5f);//リスト全体に割り算可能(test)
            Debug.Log("vertices[1] = " + vertices[1]);
            //vertices配列全体をClickSphere.distanceで割って、新しいdistanceをverticesに掛ければ距離を変更できるかもしれない
            Mesh mesh = new Mesh();
            
            mesh.SetVertices(vertices);
            mesh.SetTriangles(triangles, 0);

            MeshFilter meshFilter = GetComponent<MeshFilter>();
            meshFilter.mesh = mesh;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void test()
    {
        Debug.Log("this is test");
    }

    public void maketriangle()
    {

        Mesh mesh = new Mesh();
        //public List<Vector3> vertices = new List<Vector3>
        //{
        //    new Vector3(-1,0,0),
        //    new Vector3(0,1,0),
        //    new Vector3(1,0,0)
        //};
        mesh.SetVertices(vertices);
        mesh.SetTriangles(triangles, 0);

        MeshFilter meshFilter = GetComponent<MeshFilter>();
        meshFilter.mesh = mesh;

        foreach (Vector3 name in vertices)
        {
            Debug.Log(name);
        }
    }

    public void addvertice(Vector3 vertice)
    {
        vertices.Add(vertice);

        //最初の三角形の生成は例外処理とする
        if (triangles.Count < 3)
        {
            triangles.Add(index);
            index++;
        }
        //基本処理
        else if(triangles.Count >= 3)
        {
            triangles.Add(0);
            triangles.Add(index - 1);
            triangles.Add(index);
            index++;
        }
        Debug.Log("現在の頂点インデックス------------------");
        foreach (int name in triangles)
        {
            Debug.Log(name);
        }
        Debug.Log("----------------------------------");
        Debug.Log("現在の頂点リスト------------------");
        foreach (Vector3 name in vertices)
        {
            Debug.Log(name);
        }
        Debug.Log("----------------------------------");
    }

    public void delvertice()
    {
        //最初の三角形の生成は例外処理とする
        if (triangles.Count < 4)
        {
            triangles.RemoveAt(triangles.Count - 1);
            vertices.RemoveAt(vertices.Count - 1);
            index--;
        }
        //基本処理
        else
        {
            triangles.RemoveAt(triangles.Count - 1);
            triangles.RemoveAt(triangles.Count - 1);
            triangles.RemoveAt(triangles.Count - 1);
            vertices.RemoveAt(vertices.Count - 1);
            index--;
        }
        Debug.Log("現在の頂点インデックス------------------");
        foreach (int name in triangles)
        {
            Debug.Log(name);
        }
        Debug.Log("----------------------------------");
        Debug.Log("現在の頂点リスト------------------");
        foreach (Vector3 name in vertices)
        {
            Debug.Log(name);
        }
        Debug.Log("----------------------------------");
    }
}
