using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    //Private variables
   
    [SerializeField] float horsePower = 20000.0f;
    [SerializeField] float turnSpeed = 70.0f;
    [SerializeField] float speed;
    [SerializeField] TextMeshProUGUI speedometerText;
    [SerializeField] TextMeshProUGUI rPM;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody playerRb;
    [SerializeField] GameObject centerOfMass;
    [SerializeField] List<WheelCollider> allWheels;
    [SerializeField] int WheelsOnGround;


    // Update is called once per frame
    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.localPosition;
    }

    private void Update()
    {
        speed = Mathf.Round(playerRb.velocity.magnitude * 2.237f); // 3.6 for kph
        speedometerText.SetText("Speed: " + speed + "mph");
        rPM.SetText("RPM: " + (speed % 30) * 42); 
    }
    //use fixedUpdate() for movement and for physics related functions.
    void FixedUpdate()
    {
        //where we get input information from the player
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // we move the vehicle forward
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        playerRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);
        
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        
    }

    bool IsOnGround()
    {
        WheelsOnGround = 0;
        foreach (WheelCollider wheel in allWheels)
        {
            if (wheel.isGrounded)
            {
                WheelsOnGround++;
            }
        }
        if (WheelsOnGround == 4)
        {
            return true;
        } else
        {
            return false;
        }
    }
}
