using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Button_Script : MonoBehaviour
{
    public void PlayGame()
    {
        // Load main game scene
        SceneManager.LoadScene(2);
    }
}
