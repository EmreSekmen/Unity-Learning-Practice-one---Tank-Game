using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApacheRotate : MonoBehaviour
{
    public float PervaneRotateSpeed = 2000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * PervaneRotateSpeed);
    }
}
