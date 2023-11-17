using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerUniversal : MonoBehaviour
{
    public GameObject pauseObj;

    private bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PauseGame();
    }

    public void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPaused = !isPaused;
                pauseObj.SetActive(isPaused);
                
        }

        if (isPaused )
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
