using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goose_Collision_Detection : MonoBehaviour
{
    private void OnCollisionEnter2D (Collision2D Collision)
    {
        if (Collision.gameObject.name == "CoinPlayer")
        {
            Debug.Log("Collided HAHA");
            GameOver();
        }
    }

    public void GameOver()
    {
        // Add your game over logic here
        Debug.Log("Game Over!");

        // Reload the current scene (you can adjust this based on your game design)
        ReloadScene();
    }

    void ReloadScene()
    {
        // Get the current scene index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Reload the current scene
        SceneManager.LoadScene(currentSceneIndex);
    }
    
}
