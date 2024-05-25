using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public GameObject player { get; set; }
    [SerializeField] Vector3 offset = new Vector3(-12, 7, -7);

    // Update is called once per frame
    void LateUpdate()
    {
        //camera behind the player (if offset is not 0)
        transform.position = player.transform.position + offset;
        transform.rotation = player.transform.rotation;
    }
}
