using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
        Debug.Log("return pressed");
    }

    public void SelectCar(int carId)
    {
        GameManager.Instance.selectedCar = carId;

        SceneManager.LoadScene(1);

    }
}
