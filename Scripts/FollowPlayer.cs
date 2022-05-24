using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    Vector3 Position;
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Position = transform.position;
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.transform.position + Position;
    }
}
