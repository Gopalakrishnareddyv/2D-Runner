using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject[] obst;
    //int a=1;
    // Start is called before the first frame update
    void Start()
    {
        /*if (a == 0)
        {
            CancelInvoke();
        }
        else
        {
            InvokeRepeating("spawn", 2.0f, 2.0f);
        }*/
        InvokeRepeating("spawn", 2.0f, 2.0f);

    }
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Play")
        {
            a = 0;
        }
    }
    */
    // Update is called once per frame
    void spawn()
    {
        int value = Random.Range(0, obst.Length);
        GameObject obstspn =Instantiate(obst[value]);
        //print(gameObject.name);
        obstspn.transform.position = new Vector2(11, -3);
    }
    private void Update()
    {
        
    }
    

}
