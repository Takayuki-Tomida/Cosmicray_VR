using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class show_tips5km : MonoBehaviour//Text��
{
    static int f = 0;
    private Text text;
    private Image image;
    public float red, green, blue;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();//Text�R���|�[�l���g�����
        IEnumerator coroutine = maketransparent();
        StartCoroutine(coroutine);
        f = 1;
    }

    void OnEnable()
    {
        if(f == 1)
        {
            StartCoroutine("maketransparent");
        }
        
    }

    private IEnumerator maketransparent()
    {
        float alfa;//���ߓx�Ɋւ���p�����[�^�ł��郿�l�Ɋւ���ϐ�
        float i = 0;
        alfa = GetComponent<Text>().color.a;//���ߓx�i���l�j�̏����l��ݒ�
        alfa = 1.0f;
        //panel�̐F���擾
        red = GetComponent<Text>().color.r;
        green = GetComponent<Text>().color.g;
        blue = GetComponent<Text>().color.b;
        
        GetComponent<Text>().color = new Color(red, green, blue, 0);
        for (int j = 0; j <= 80; j++)
        { //�ȉ�fading
            i += 0.0125f; //���l����
            GetComponent<Text>().color = new Color(red, green, blue, i); //color�l�ݒ�
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(8.1f);//�������̕\�����Ԃ̃p�����[�^

        for (int j = 0; j <= 200; j++)
        { //�ȉ�fading
            alfa -= 0.007f; //���l����
            GetComponent<Text>().color = new Color(red, green, blue, alfa); //color�l�ݒ�
            yield return new WaitForSeconds(0.01f);
        }

        GetComponent<Text>().color = new Color(red, green, blue, 0); //alfa�l���}�C�i�X�ɂȂ��Ă���̂�0�ŏ㏑��

        yield return new WaitForSeconds(3.3f);
        //Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
