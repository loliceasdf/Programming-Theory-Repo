using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Car : MonoBehaviour
{
    //Private variables
   public static Car Instance { get; protected set; }

    [SerializeField] float horsePower = 20000.0f;
    [SerializeField] float speed;
    private float horizontalInput;
    private float verticalInput;
    protected Rigidbody playerRb;
    [SerializeField] List<Wheel> allWheels;
    [SerializeField] int WheelsOnGround;


    protected void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        } else { Destroy(gameObject); }
    }
    // Update is called once per frame
    protected void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        SetCenterOfMass();
    }

    protected void Update()
    {
        HandleRpm();
    }
    //use fixedUpdate() for movement and for physics related functions.
    protected void FixedUpdate()
    {
        //ABSTRACTION
       
            HandleDriving();
    }

    protected void SetCenterOfMass() { playerRb.centerOfMass = CenterOfMass.Instance.transform.localPosition;
       
    }
    protected void HandleRpm()
    {
        speed = Mathf.Round(playerRb.velocity.magnitude * 2.237f); // 3.6 for kph
        GamePlayUi.Instance.speed.SetText("Speed: " + speed + "mph");
        GamePlayUi.Instance.rpm.SetText("RPM: " + (speed % 30) * 42);
    }

    protected void HandleDriving()
    { //where we get input information from the player
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // we move the vehicle forward
        // playerRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);
        foreach (Wheel w in allWheels)
        {
            w.Steer(horizontalInput);
            w.Accelerate(verticalInput * horsePower);
            w.UpdatePosition();
        }
     //   transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
    
   // protected bool IsOnGround()
   // {
     //   WheelsOnGround = 0;
     //   foreach (WheelCollider wheel in allWheels)
      //  {
     ///       if (wheel.isGrounded)
     //       {
      //          WheelsOnGround++;
      //      }
     //   }
     //   if (WheelsOnGround >= 2)
     //   {
     //       return true;
    //    } else
    //    {
    //        return false;
    //    }
   // }
}
