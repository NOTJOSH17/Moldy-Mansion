using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    public GameObject GameCanvas;
    public GameObject GameWinCanvas;
    public GameObject Sounds;
    public AudioSource GameWinsSong;


 
    void Start()
    {
 
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
	{
		//PlayerMovement player = hitInfo.GetComponent<PlayerMovement>();
		if(hitInfo.gameObject.tag == "Player")
		{
            GameCanvas.SetActive(false);
            GameWinCanvas.SetActive(true);
            Sounds.SetActive(false);
            GameWinsSong.Play();
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
    

}
