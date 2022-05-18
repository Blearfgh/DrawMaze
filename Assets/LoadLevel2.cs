using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel2 : MonoBehaviour
{
    public GameObject thePlayer;

  
    void OnTriggerEnter2D(Collider2D Pelaaja)
    {
        if (Pelaaja.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Level2");
        }
    }
   
}
