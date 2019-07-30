using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    public GameObject Gate;
    
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //player = GameObject.FindGameObjectWithTag("Player");
        if (hitInfo.gameObject.tag == "Player")
        {
            Gate.SetActive(false);
            Destroy(gameObject);
        }
        
    }
}
