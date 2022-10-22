using UnityEngine;
using UnityEngine.SceneManagement;

public class DigSpot : MonoBehaviour
{
    public string scene;
    public int spotNumber;
    public int pairedSpotNumber;

    public Vector2 pairedSpotPos;

    private SpriteRenderer spriteRenderer;
    public Sprite closed;
    public Sprite open;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (GameVariables.digSpots[pairedSpotNumber - 1])
        {
            spriteRenderer.sprite = open;
        }
        else
        {
            spriteRenderer.sprite = closed;
        }
    }

    public void LoadScene()
    {
        GameVariables.digSpots[spotNumber - 1] = true;
        SceneManager.LoadScene(scene);
        GameVariables.spawnPoint = pairedSpotPos;
    }
}
