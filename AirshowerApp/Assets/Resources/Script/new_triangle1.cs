using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_triangle1 : MonoBehaviour
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
            new_triangle2 tr2 = GetComponent<new_triangle2>();
            tr2.maketriangle();
        }
    }
}