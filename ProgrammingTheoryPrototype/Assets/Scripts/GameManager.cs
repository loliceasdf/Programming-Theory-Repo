using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    int selectedCar;
    List<GameObject> cars = new List<GameObject>();

    public void SelectCar(int carId)
    {
        selectedCar = carId;
        //TODO:Load the play scene.
        SceneManager.LoadScene(1);
        //Instantiate(cars[carId]);
    }
}
