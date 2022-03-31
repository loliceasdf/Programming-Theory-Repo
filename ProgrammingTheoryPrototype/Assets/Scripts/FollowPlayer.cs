using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    [SerializeField] Vector3 offset = new Vector3(0, 5, -7);



    // Update is called once per frame

    //use LateUpdate() for Camera based movement.
    void LateUpdate()
    {
        // offset camera nbehind palyer and follow
        transform.position = player.transform.position + offset;
            ;
    }
}
 