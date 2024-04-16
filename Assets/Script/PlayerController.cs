using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    Rigidbody playerRb;

    [SerializeField] GameObject CenterOfMass;
    [SerializeField] TextMeshProUGUI speedometerText;
    [SerializeField] TextMeshProUGUI rpmText;

    float horsePower = 25000.0f;
    float turnSpeed = 20.0f;
    float horizontalInput;
    float verticalInput;
    float speed;
    float rpm;

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

        speed = Mathf.RoundToInt(playerRb.velocity.magnitude * 2.237f);
        speedometerText.SetText("Speed: " + speed + " mph");

        rpm = (speed % 30) * 40;
        rpmText.SetText("RPM: " + rpm);

        playerRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
