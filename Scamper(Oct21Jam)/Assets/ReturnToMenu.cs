using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{
    public void ReturnGame()
    {
        // Loads the Main menu again.
        SceneManager.LoadScene(0);
    }
}
