using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public GameObject GameCanvas;
    public GameObject GameOverCanvas;
    public GameObject Sounds;
    public GameObject Player;
    public AudioSource GameOverSong;


     public void Menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT GAME");
        Application.Quit();
    }
    public void GameOver()
    {
       
        Sounds.SetActive(false);
        GameOverSong.Play();
        GameCanvas.SetActive(false);
        GameOverCanvas.SetActive(true);
        Destroy(Player);
    }


}
