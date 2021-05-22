using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    Rigidbody2D rbobst;
    public float obstspeed;
    // Start is called before the first frame update
    void Start()
    {
        rbobst = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rbobst.velocity = new Vector2(-1,0)*obstspeed;
    }
}
