using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muzzle : MonoBehaviour
{

    public float muzzlespeed = 10f;
    public float horizontalInput;
    public float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.UpArrow))
        {
         
            transform.Rotate(-17f * Time.deltaTime * muzzlespeed * verticalInput, transform.rotation.y, transform.rotation.z);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(-1f * Time.deltaTime * muzzlespeed * verticalInput, transform.rotation.y, transform.rotation.z);
        }
    }
}
