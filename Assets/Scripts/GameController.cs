using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject StartButton;
    // Start is called before the first frame update
    void Start()
    {
        switch(SceneManager.GetActiveScene().name)
        {
            case ("Main"):
                Debug.Log("Start scene!");
                break;
            case ("Level1Scene"):
                Debug.Log("Level1 scene!");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnStartButtonClick()
    {
        SceneManager.LoadScene("Level1Scene");
        Debug.Log("Scene is changed to Level 1!");
    }
    public void OnExitButtonClick()
    {
        Debug.Log("Game is terminated!");
        Application.Quit();
    }
}
