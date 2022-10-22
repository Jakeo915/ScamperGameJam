using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<MouseController>() != null)
        {
            GameVariables.spawnPoint = transform.position;
        }
    }
}
