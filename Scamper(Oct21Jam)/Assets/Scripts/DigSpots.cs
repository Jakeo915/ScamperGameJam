using UnityEngine;

public class DigSpots : MonoBehaviour
{
    [SerializeField] private GameController controller;

    void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.CompareTag("HollowCheck"))
        //{
        controller.isHollow = true;
        //}
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        //if (collision.gameObject.CompareTag("HollowCheck"))
        //{
        controller.isHollow = false;
        //}
    }
}