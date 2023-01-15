using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�@�N���b�N�����ʒu�ɋ���z�u����
//�A�N���b�N�������W���L�^���Adistance���|���ĔC�ӂ̋����̍��W���𓾂�
public class new_ClickSphere : MonoBehaviour
{
    public GameObject prefab;
    public GameObject[] vertex_num = new GameObject[200];//�������鋅�̐��̏��������
    private Vector3 mousePosition;
    int i = 0;
    float theta = 0f;
    float phi = 0f;
    float fixed_x, fixed_y, fixed_z;
    public int distance = 70;//�R�̏ꍇ70�A�����̏ꍇ40
    public static List<Vector3> vertex_list = new List<Vector3>();
    Vector3 v = new Vector3(0f, 0f, 0f);


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePosition = Input.mousePosition;
            mousePosition.z = 50.0f;//�K���Ȓl�Őݒ�i���̒l�͏d�v�łȂ��j
            //vertex_list = Camera.main.ScreenToWorldPoint(mousePosition);

            //���𐶐�����----------------------------------------------------
            //Debug.Log("�N���b�N���ꂽ���W�� " + Camera.main.ScreenToWorldPoint(mousePosition));
            vertex_num[i] = Instantiate(prefab, Camera.main.ScreenToWorldPoint(mousePosition), Quaternion.identity);
            i++;
            //----------------------------------------------------------------

            v = Camera.main.ScreenToWorldPoint(mousePosition);

            new_triangle2 tr2 = GetComponent<new_triangle2>();
            //���̍��W���J�������炠����̒l�̋����ɂȂ�悤����
            //(x,y,z)��(��,��)
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
                Debug.Log($"���_����{vertex_list.Count}�ł�");
            }

            //----------------------------------------------------------------
        }

        if (Input.GetMouseButtonDown(1))//�����폜
        {
            i--;
            Destroy(vertex_num[i]);
            new_triangle2 tr2 = GetComponent<new_triangle2>();
            tr2.delvertice();
        }

        if (Input.GetKeyDown(KeyCode.P))//�z��Ɋi�[���ꂽ���_�f�[�^������
        {
            foreach (Vector3 name in vertex_list)
            {
                Debug.Log(name);
            }
        }
    }
}
