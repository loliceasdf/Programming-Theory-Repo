using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    public static GameManager Instance { get; private set; }
   public int selectedCar;
    List<GameObject> cars = new List<GameObject>();

    private void Awake()
    {
        if (Instance == null) { Instance = this; } else { Destroy(gameObject); }
    }
    public void SelectCar(int carId)
    {
        selectedCar = carId;
        //TODO:Load the play scene.
        SceneManager.LoadScene(1);
        //Instantiate(cars[carId]);
    }
}
