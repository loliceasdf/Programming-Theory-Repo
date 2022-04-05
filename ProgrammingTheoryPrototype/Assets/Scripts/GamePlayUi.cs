using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GamePlayUi : MonoBehaviour
{

    public static GamePlayUi Instance { get; set; }
   public  TMP_Text rpm;
     public TMP_Text speed;
    private TMP_Text[] childrenText;
    public int selectedCar;

    // Start is called before the first frame update
    void Awake()
    {
        //Singleton
        if (Instance == null)
        {
            Instance = this;
        } else
        {
            Destroy(gameObject);
        }

        
        //fill childrentext array with the tmp text components found in the children of the canvas game onject so they can be set in the car class.
        childrenText = GetComponentsInChildren<TMP_Text>();
        rpm = childrenText[0];
        speed = childrenText[1];
        
    }
   

}
