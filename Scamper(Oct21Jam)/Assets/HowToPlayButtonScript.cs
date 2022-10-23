using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlayButtonScript : MonoBehaviour
{
    public void HowToPlayGame()
    {
        // Loads into image that explains how to play the game.
        SceneManager.LoadScene(1);
    }
}
