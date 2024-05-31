using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    [SerializeField] protected float speed = 10.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    private Camera cam;
    // Start is called before the first frame update
    void Awake()
    {
        cam = Camera.main;
        cam.GetComponent<PlayerCamera>().player = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        // ABSTRACTION
        PlayerControl();
    }

    // INHERITANCE
    protected virtual void PlayerControl()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
