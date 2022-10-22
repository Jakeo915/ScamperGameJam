using UnityEngine;
using UnityEngine.SceneManagement;

public class DigSpot : MonoBehaviour
{
    public string scene;
    public float mouseXPosInNewScene;
    public float mouseYPosInNewScene;

    public void LoadScene()
    {
        SceneManager.LoadScene(scene);
        GameVariables.mouseXPos = mouseXPosInNewScene;
        GameVariables.mouseYPos = mouseYPosInNewScene;
    }
}
