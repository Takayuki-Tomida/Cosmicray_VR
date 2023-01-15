using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetHaikei : MonoBehaviour
{
    public Material[] mat;
    public int i = 0;
   
    // Start is called before the first frame update
    void Start()
    {
        IEnumerator coroutine = SetMat();
        StartCoroutine(coroutine);
    }


    IEnumerator SetMat()
    {
        while (true)
        {
            this.GetComponent<Renderer>().material = mat[i];
            yield return new WaitForSeconds(0.6f);
            i++;
            if (i == 15)
            {
                i = 0;
            }
        }
    }

    
}

