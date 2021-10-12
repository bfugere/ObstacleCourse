using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngle = 0f;
    [SerializeField] float yAngle = 150f;
    [SerializeField] float zAngle = 0f;

    void Update()
    {
        Spin();
    }

    void Spin()
    {
        float xSpin = xAngle * Time.deltaTime;
        float ySpin = yAngle * Time.deltaTime;
        float zSpin = zAngle * Time.deltaTime;

        transform.Rotate(xSpin, ySpin, zSpin);
    }
}
