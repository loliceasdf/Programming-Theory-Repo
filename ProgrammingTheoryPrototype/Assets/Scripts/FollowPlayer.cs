using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] List<Car> cars;
    
    [SerializeField] Vector3 offset = new Vector3(0, 5, -7);

    public int carSelectionId;


    private void Awake()
    {
        Instantiate(cars[GameManager.Instance.selectedCar]);
    }
    // Update is called once per frame

    //use LateUpdate() for Camera based movement.
    void LateUpdate()
    {
        // offset camera nbehind palyer and follow
        transform.position = Car.Instance.transform.position + offset;
            
    }
}
 