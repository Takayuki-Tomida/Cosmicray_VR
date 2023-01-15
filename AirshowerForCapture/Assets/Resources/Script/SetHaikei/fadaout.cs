using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadaout : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        IEnumerator coroutine = fade();
        StartCoroutine(coroutine);
    }
    
    IEnumerator fade()
    {
        Material EarlyMorning_Left = Resources.Load("Texture/test/" + "EarlyMorning_Left") as Material;
        
        Material Noon_Left = Resources.Load("Texture/test/" + "Noon_Left") as Material;
        
        Material Evening_Left = Resources.Load("Texture/test/" + "Evening_Left") as Material;
        
        Material LaterEvening_Left = Resources.Load("Texture/test/" + "LaterEvening_Left") as Material;

        int cnt = 0;
        GameObject Spheretest3 = GameObject.Find("Spheretest3");
        while (true)
        {
            if(cnt == 0)
            {
                yield return new WaitForSeconds(150f);
            }
            else
            {
                yield return new WaitForSeconds(14.2f);
            }
            
            HaikeiManager.haikei_flag = 1;
            yield return new WaitForSeconds(0.8f);
            for (int i = 0; i < 100; i++)
            {
                this.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.01f);
                yield return new WaitForSeconds(0.05f);
                //if (i == 50)
                //{
                //    Manager.delete(1);//朝の透明オブジェクトを消去
                //    HaikeiManager.haikei_flag = 0;
                //}
            }
            
            yield return new WaitForSeconds(14.2f);

            this.GetComponent<Renderer>().material = Evening_Left;

            HaikeiManager.haikei_flag = 1;
            yield return new WaitForSeconds(0.8f);
            for (int i = 0; i < 100; i++)
            {
                this.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.01f);
                yield return new WaitForSeconds(0.05f);
                if (i == 50)
                {
                    Manager.delete(2);//昼の透明オブジェクトを消去
                    HaikeiManager.haikei_flag = 0;
                }
            }
            

            Spheretest3.GetComponent<Renderer>().material = LaterEvening_Left;

            yield return new WaitForSeconds(14.2f);
            HaikeiManager.haikei_flag = 1;
            yield return new WaitForSeconds(0.8f);
            for (int i = 0; i < 100; i++)
            {
                this.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.01f);
                yield return new WaitForSeconds(0.05f);
                if (i == 50)
                {
                    Manager.delete(3);//夕の透明オブジェクトを消去
                    HaikeiManager.haikei_flag = 0;
                }
            }
            
            this.GetComponent<Renderer>().material = EarlyMorning_Left;

            yield return new WaitForSeconds(14.2f);
            HaikeiManager.haikei_flag = 1;
            yield return new WaitForSeconds(0.8f);
            for (int i = 0; i < 100; i++)
            {
                this.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.01f);
                yield return new WaitForSeconds(0.05f);
                if (i == 50)
                {
                    Manager.delete(4);//夜の透明オブジェクトを消去
                    HaikeiManager.haikei_flag = 0;
                }

            }
            
            Spheretest3.GetComponent<Renderer>().material = Noon_Left;
            cnt++;
        }
        
    }
    // Update is called once per frame
    void Update()
    {

    }
    
}
