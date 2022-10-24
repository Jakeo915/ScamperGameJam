using UnityEngine;
using UnityEngine.Tilemaps;

public class GameController : MonoBehaviour
{
    private bool inWall;
    public bool isHollow;
    public GameObject outsideWall;
    public GameObject insideWall;
    public GameObject insideWallTunnels;
    [SerializeField] SpriteRenderer insideSprite;
    [SerializeField] SpriteRenderer outsideSprite;
    [SerializeField] Animator mouseAnimator;

    public MouseController scamper;

    public Vector2 spawnPoint;

    public AudioSource source;
    public AudioClip solidSound;
    public AudioClip hollowSound;
    public Sprite holePrefab;

    private int knockDelay = 25;

    void Start()
    {
        spawnPoint = new Vector2(-171f, -3.8f);
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
                    insideSprite.enabled = false;
                    outsideWall.GetComponent<TilemapCollider2D>().enabled = true;
                    outsideSprite.enabled = true;
                    insideWallTunnels.GetComponent<TilemapRenderer>().enabled = false;

                }
                // Go in wall
                else
                {
                    inWall = true;
                    insideWall.GetComponent<TilemapCollider2D>().enabled = true;
                    insideSprite.enabled = true;
                    outsideWall.GetComponent<TilemapCollider2D>().enabled = false;
                    outsideSprite.enabled = false;
                    insideWallTunnels.GetComponent<TilemapRenderer>().enabled = true;
                }

                scamper.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
                scamper.GetComponent<Rigidbody2D>().AddForce(Vector2.up * .001f);
                mouseAnimator.SetBool("inWall", inWall);
            }
        }
    }
    void FixedUpdate()
    {
        knockDelay--;
    }
}
