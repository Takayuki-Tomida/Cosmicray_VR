using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeout2 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        IEnumerator coroutine = fade();
        StartCoroutine(coroutine);
    }

    IEnumerator fade()
    {
        
        Material EarlyMorning_Left2 = Resources.Load("Texture/test/" + "EarlyMorning_Left2") as Material;
        
        Material Noon_Left2 = Resources.Load("Texture/test/" + "Noon_Left2") as Material;
        
        Material Evening_Left2 = Resources.Load("Texture/test/" + "Evening_Left2") as Material;
        
        Material LaterEvening_Left2 = Resources.Load("Texture/test/" + "LaterEvening_Left2") as Material;

        GameObject Spheretest4 = GameObject.Find("Spheretest4");

        int cnt = 0;
        while (true)
        {
            if(cnt == 0)
            {
                yield return new WaitForSeconds(150f);
            }
            else
            {
                yield return new WaitForSeconds(15f);
            }

            for (int i = 0; i < 100; i++)
            {
                this.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.01f);
                yield return new WaitForSeconds(0.05f);
            }

            yield return new WaitForSeconds(15f);

            this.GetComponent<Renderer>().material = Evening_Left2;

            for (int i = 0; i < 100; i++)
            {
                this.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.01f);
                yield return new WaitForSeconds(0.05f);
            }

            Spheretest4.GetComponent<Renderer>().material = LaterEvening_Left2;

            yield return new WaitForSeconds(15f);

            for (int i = 0; i < 100; i++)
            {
                this.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.01f);
                yield return new WaitForSeconds(0.05f);
            }

            this.GetComponent<Renderer>().material = EarlyMorning_Left2;

            yield return new WaitForSeconds(15f);

            for (int i = 0; i < 100; i++)
            {
                this.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.01f);
                yield return new WaitForSeconds(0.05f);
            }

            Spheretest4.GetComponent<Renderer>().material = Noon_Left2;
            cnt++;
        }

    }
    // Update is called once per frame
    void Update()
    {

    }

}
