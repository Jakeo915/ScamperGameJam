using UnityEngine;

public class MouseTrap : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        MouseController scamper = collision.GetComponent<MouseController>();
        if (scamper != null)
        {
            scamper.Die();
        }
    }
}
