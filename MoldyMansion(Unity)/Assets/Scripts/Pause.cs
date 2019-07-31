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
    public AudioSource LevelSong;
    public GameObject Player;
    public GameObject Level;
    bool isPaused;
    int pressCounter;

 
    void Start()
    {
        isPaused = false;
        pressCounter = 0;
        LevelSong.Play();
    }

    void Update()
    {
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
            LevelSong.Pause();
        }
        else
        {
            LevelSong.UnPause();
        }
        if (isPaused == false)
        {
            UnPauseGame();
        }
    }

    public void Menu()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        SceneManager.LoadScene(1); //more efficent than above 
        
    }
    public void QuitGame()
    {
        Debug.Log("QUIT GAME");
        Application.Quit();
    }
    
    public void PauseGame()
    {
        Player.SetActive(false);
        Level.SetActive(false);
        Sounds.SetActive(false);
        GameCanvas.SetActive(false);
        GameOverCanvas.SetActive(true);
        
    }
    public void UnPauseGame()
    {
        Player.SetActive(true);
        Level.SetActive(true);
        Sounds.SetActive(true);
        GameCanvas.SetActive(true);
        GameOverCanvas.SetActive(false);
    }
}
