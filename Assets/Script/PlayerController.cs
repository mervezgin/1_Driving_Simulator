using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody playerRb;

    [SerializeField] float horsePower = 0f;
    [SerializeField] GameObject CenterOfMass;

    //float speed = 15.0f;
    float turnSpeed = 20.0f;
    float horizontalInput;
    float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = CenterOfMass.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        playerRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
