using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLeftRight : MonoBehaviour
{
    Rigidbody2D playerrb;
    public float speed;
    SpriteRenderer PlayerSprite;
    // Start is called before the first frame update
    void Start()
    {
        playerrb = GetComponent<Rigidbody2D>();
        PlayerSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerrb.velocity =Vector2.left*speed;
            PlayerSprite.flipX = true;

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerrb.velocity = Vector2.right*speed;
            PlayerSprite.flipX = false;
        }
    }
}
