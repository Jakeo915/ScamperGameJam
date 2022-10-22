using UnityEngine;

public class Dig : MonoBehaviour
{
    public AudioSource source;
    public AudioClip solidSound;
    public AudioClip hollowSound;

    [SerializeField] Transform digCheck;
    [SerializeField] private LayerMask digLayer;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (IsDigSpot())
            {
                source.PlayOneShot(hollowSound);
            }
            else
            {
                source.PlayOneShot(solidSound);
            }
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.G))
        {
            if (IsDigSpot())
            {
                collision.GetComponent<DigSpot>().LoadScene();
            }
            else
            {
                // Some penalty for digging in the wrong spot
            }
        }
    }

    private bool IsDigSpot()
    {
        return Physics2D.OverlapCircle(digCheck.position, 0.2f, digLayer);
    }
}
