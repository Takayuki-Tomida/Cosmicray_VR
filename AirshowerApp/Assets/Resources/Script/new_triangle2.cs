using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_triangle2 : MonoBehaviour
{
    public List<Vector3> vertices = new List<Vector3> {};
    int index = 0;
    public List<int> triangles = new List<int> {};
    public int newdistance = 77;//�R�̓����I�u�W�F�N�g�̋�������

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("vertices.count = " + vertices.Count);
        new_ClickSphere CS = GetComponent<new_ClickSphere>();
        if (vertices.Count != 0)
        {
            for (int i = 0; i < vertices.Count; i++)
            {
                //Debug.Log(vertices[i]);
                vertices[i] = vertices[i] / (float)CS.distance;
                vertices[i] = vertices[i] * (float)newdistance;
            }

            //Debug.Log(vertices[1]/5f);//���X�g�S�̂Ɋ���Z�\(test)
            //Debug.Log(vertices[1]);
            //vertices�z��S�̂�ClickSphere.distance�Ŋ����āA�V����distance��vertices�Ɋ|����΋�����ύX�ł���
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

        //�ŏ��̎O�p�`�̐����͗�O�����Ƃ���
        if (triangles.Count < 3)
        {
            triangles.Add(index);
            index++;
        }
        //��{����
        else if (triangles.Count >= 3)
        {
            triangles.Add(index - 2);
            triangles.Add(index - 1);
            triangles.Add(index);
            index++;
        }
        Debug.Log("���݂̒��_�C���f�b�N�X------------------");
        foreach (int name in triangles)
        {
            Debug.Log(name);
        }
        Debug.Log("----------------------------------");
        Debug.Log("���݂̒��_���X�g------------------");
        foreach (Vector3 name in vertices)
        {
            Debug.Log(name);
        }
        Debug.Log("----------------------------------");
    }

    public void delvertice()
    {
        //�ŏ��̎O�p�`�̐����͗�O�����Ƃ���
        if (triangles.Count < 4)
        {
            triangles.RemoveAt(triangles.Count - 1);
            vertices.RemoveAt(vertices.Count - 1);
            index--;
        }
        //��{����
        else
        {
            triangles.RemoveAt(triangles.Count - 1);
            triangles.RemoveAt(triangles.Count - 1);
            triangles.RemoveAt(triangles.Count - 1);
            vertices.RemoveAt(vertices.Count - 1);
            index--;
        }
        Debug.Log("���݂̒��_�C���f�b�N�X------------------");
        foreach (int name in triangles)
        {
            Debug.Log(name);
        }
        Debug.Log("----------------------------------");
        Debug.Log("���݂̒��_���X�g------------------");
        foreach (Vector3 name in vertices)
        {
            Debug.Log(name);
        }
        Debug.Log("----------------------------------");
    }
}