using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : Car
{
    //INHERITANCE
    //Using all the functions of the part class

    //POLYMORPHISM 
    //adding the destroy boxes feature exclusive to the tank class

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}
