using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] List<Car> cars;
    
    [SerializeField] Vector3 offset = new Vector3(0, 5, -7);
    [SerializeField] Vector3 tankOffset = new Vector3(0, 8, -7);

    public int carSelectionId;


    private void Awake()
    {
        //SPawn car
       
        
            Instantiate(cars[GameManager.Instance.selectedCar]);
        
        
    }
    // Update is called once per frame

    //use LateUpdate() for Camera based movement.
    void LateUpdate()
    {
        // offset camera behind player and follow
       
        if (GameManager.Instance.selectedCar ==1)
        {
            offset = tankOffset;
        }

        HandleCameraOffset();
            
    }

    void HandleCameraOffset()
    {
        transform.position = Car.Instance.transform.position + offset;
    }
}
 