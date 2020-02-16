﻿
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    bool gamehasEnded = false;
   public void EndGame()
    {
        if(gamehasEnded == false)
        {
            gamehasEnded = true;
            Debug.Log("GAME OVER");
            Restart();

        }
        void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
        
    }
}
