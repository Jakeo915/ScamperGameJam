using UnityEngine;
using UnityEngine.Tilemaps;

public class GameController : MonoBehaviour
{
    private bool inWall;
    public bool isHollow;
    public GameObject outsideWall;
    public GameObject insideWall;

    public MouseController scamper;

    public Vector2 spawnPoint;

    public AudioSource source;
    public AudioClip solidSound;
    public AudioClip hollowSound;
    public Sprite holePrefab;

    private int knockDelay = 25;

    void Start()
    {
        spawnPoint = new Vector2(-415.34f, 1f);
        inWall = false;
        isHollow = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (scamper.IsGrounded())
        {
            if (Input.GetKeyDown(KeyCode.F) && knockDelay < 0)
            {
                knockDelay = 25;
                if (isHollow)
                {
                    source.PlayOneShot(hollowSound);
                }
                else
                {
                    source.PlayOneShot(solidSound);
                }
            }

            if (Input.GetKeyDown(KeyCode.G) && isHollow)
            {
                scamper.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;

                //Instantiate(holePrefab, scamper.transform);

                // Go outside of wall
                if (inWall)
                {
                    inWall = false;
                    insideWall.GetComponent<TilemapCollider2D>().enabled = false;
                    insideWall.GetComponent<TilemapRenderer>().enabled = false;
                    outsideWall.GetComponent<TilemapCollider2D>().enabled = true;
                    outsideWall.GetComponent<TilemapRenderer>().enabled = true;
                }
                // Go in wall
                else
                {
                    inWall = true;
                    insideWall.GetComponent<TilemapCollider2D>().enabled = true;
                    insideWall.GetComponent<TilemapRenderer>().enabled = true;
                    outsideWall.GetComponent<TilemapCollider2D>().enabled = false;
                    outsideWall.GetComponent<TilemapRenderer>().enabled = false;
                }

                scamper.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
                scamper.GetComponent<Rigidbody2D>().AddForce(Vector2.up * .001f);
            }
        }
    }
    void FixedUpdate()
    {
        knockDelay--;
    }
}
