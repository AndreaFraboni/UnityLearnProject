using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float Speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;

    public GameObject BackCamera;
    public GameObject FrontCamera;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.Alpha1))
        {
            if (!BackCamera.active)
            {
                BackCamera.SetActive(true);
                FrontCamera.SetActive(false);
            }
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            if (!FrontCamera.active)
            {
                BackCamera.SetActive(false);
                FrontCamera.SetActive(true);
            }
        }

        //transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * Time.deltaTime * Speed * forwardInput);
        //transform.Translate(Vector3.right * Time.deltaTime * turnspeed * horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

    }
}
