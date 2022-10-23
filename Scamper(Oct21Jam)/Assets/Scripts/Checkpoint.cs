using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        MouseController scamper = collision.GetComponent<MouseController>();
        if (scamper != null)
        {
            scamper.controller.spawnPoint = transform.position;
        }
    }
}
