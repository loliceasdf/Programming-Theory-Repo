using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Tank : Car
{
    
 

    //POLYMORPHISM 
    public override void SetHorsePower()
    {
        //tank power
        horsePower = 80000f;
    }
    //adding the destroy boxes feature exclusive to the tank class

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}
