//challenge 1


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    
    GameObject plane;
    GameObject propellor;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        propellor = GameObject.Find("Propeller");
        plane = GameObject.Find("Player");
        offset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        propellor.transform.Rotate(0,0,40.12443f);
        transform.position = plane.transform.position + offset;
    }
}
