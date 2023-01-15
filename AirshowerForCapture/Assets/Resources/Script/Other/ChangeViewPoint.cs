using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeViewPoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0.7f, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -0.7f, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(-0.7f, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(0.7f, 0, 0);
        }
    }
}
