using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Player;
    private UnityEngine.Vector3 cameraposition = new UnityEngine.Vector3(-1.25f, 7.25f, -10.48f);

    // Start is called before the first frame update
    void Start()
    {
        cameraposition = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + cameraposition;
    }
}
