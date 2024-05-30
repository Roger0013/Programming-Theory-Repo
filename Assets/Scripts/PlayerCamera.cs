using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public GameObject player { get; set; }
    [SerializeField] Vector3 offset = new Vector3(-12, 7, -7);
    public float smoothTime = 0.25f;
    private Vector3 currentVelocity;

    // Update is called once per frame
    void LateUpdate()
    {
        //camera behind the player (if offset is not 0)
        //transform.position = player.transform.position + offset;
        //transform.rotation = player.transform.rotation;
        Vector3 target = player.transform.position + (transform.position - player.transform.position).normalized * offset.z;
        if (target.y < player.transform.position.y + offset.y)
        {
            target.y = player.transform.position.y + offset.y;
        }
        target.x += offset.x;
        transform.position = Vector3.SmoothDamp(transform.position, target, ref currentVelocity, smoothTime);
        transform.LookAt(player.transform);
       
    }
}
