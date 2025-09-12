using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float horizontalInput;
    private float leftsideborder = -7.17f;
    private float fireDelay = 0.7f;
    private float firedelay2;
    public Transform firepoint;
    public GameObject ammo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > firedelay2)
        {
            firedelay2 = Time.time + fireDelay;
            Instantiate(ammo, firepoint.transform.position, firepoint.transform.rotation);
        }



        if(transform.position.x < leftsideborder)
        {
            transform.position = new Vector3(leftsideborder, transform.position.y, transform.position.z);
        }
        else if(transform.position.x > -leftsideborder)
        {
            transform.position = new Vector3(-leftsideborder, transform.position.y, transform.position.z);
        }



            horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed *  horizontalInput);
    }
}
