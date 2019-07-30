using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public GameObject GameCanvas;
    public GameObject GameOverCanvas;
    public GameObject Sounds;
    public AudioSource GameOverSong;
    bool isPaused;
    int pressCounter;

 
    void Start()
    {
        isPaused = false;
        pressCounter = 0;
    }

    void Update()
    {
        Debug.Log(pressCounter);
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pressCounter ++;
        }
        if(pressCounter == 1)
        {
            isPaused = true;
        }
        if (pressCounter == 2)
        {
            isPaused = false;
        }
        if (pressCounter >=3)
        {
            pressCounter = 1;
        }

        if(isPaused == true)
        {
            PauseGame();
        }
        if (isPaused == false)
        {
            UnPauseGame();
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT GAME");
        Application.Quit();
    }
    
    public void PauseGame()
    {
        Sounds.SetActive(false);
        GameCanvas.SetActive(false);
        GameOverCanvas.SetActive(true);
    }
    public void UnPauseGame()
    {
        Sounds.SetActive(true);
        GameCanvas.SetActive(true);
        GameOverCanvas.SetActive(false);
    }
}
