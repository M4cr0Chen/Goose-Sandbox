using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin_Collide_Detection : MonoBehaviour
{
    private void OnCollisionEnter2D (Collision2D Collision)
    {
        if (Collision.gameObject.name == "Cabinet_1")
        {
            Debug.Log("Coin Enter Next Level");
            EnterNextLevel();
        }
    }

    public void EnterNextLevel()
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
