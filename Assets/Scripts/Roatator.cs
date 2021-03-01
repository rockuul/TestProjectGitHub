using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roatator : MonoBehaviour
{
    public float speed = 0f;

    //public bool ForwardX = false;
    //public bool ForwardY = false;
    //public bool ForwardZ = false;

    void Update()
    {
        transform.Rotate(0, Time.deltaTime * speed, 0, Space.Self);
        //if (ForwardX == true)
        //{
        //    transform.Rotate(Time.deltaTime * speed, 0, 0, Space.Self);
        //}
        //if (ForwardY == true)
        //{
        //    transform.Rotate(0, Time.deltaTime * speed, 0, Space.Self);
        //}
        //if (ForwardZ == true)
        //{
        //    transform.Rotate(0, 0, Time.deltaTime * speed, Space.Self);
        //}
    }
}
