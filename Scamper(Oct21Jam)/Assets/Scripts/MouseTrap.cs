using UnityEngine;

public class MouseTrap : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        MouseController mouse = collision.GetComponent<MouseController>();
        if (mouse != null)
        {
            mouse.Die();
        }
    }
}
