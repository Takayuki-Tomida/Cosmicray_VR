using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triangle1 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            triangle2 tr2 = GetComponent<triangle2>();
            tr2.maketriangle();
        }
    }

    



}
